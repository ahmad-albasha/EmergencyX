import sys
import joblib
import pandas as pd
import os
import io

# ضمان UTF-8 للإخراج (مهم لـ WinForms)
sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

BASE_DIR = os.path.dirname(os.path.abspath(__file__))

# =========================
# LOAD TRAINED COMPONENTS
# =========================
model = joblib.load(os.path.join(BASE_DIR, "best_ktas_model.pkl"))
scaler = joblib.load(os.path.join(BASE_DIR, "ktas_scaler.pkl"))
label_encoder = joblib.load(os.path.join(BASE_DIR, "ktas_label_encoder.pkl"))
feature_columns = joblib.load(os.path.join(BASE_DIR, "feature_columns.pkl"))
categorical_cols = joblib.load(os.path.join(BASE_DIR, "categorical_cols.pkl"))

# =========================
# ONE-HOT ENCODER (MATCH TRAINING)
# =========================
def one_hot_encoder(df, categorical_columns, nan_as_category=False):
    return pd.get_dummies(
        df,
        columns=categorical_columns,
        dummy_na=nan_as_category,
        drop_first=False
    )

# =========================
# MAIN
# =========================
if __name__ == "__main__":

    # عدد الوسائط المتوقعة (17 + اسم السكربت)
    if len(sys.argv) != 18:
        print("Error: Invalid number of arguments", file=sys.stderr)
        sys.exit(1)

    try:
        # =========================
        # READ INPUT FROM ARGV
        # =========================
        input_data = {
            "Group": sys.argv[1],
            "Sex": sys.argv[2],
            "Patients number per hour": int(sys.argv[3]),
            "Arrival mode": sys.argv[4],
            "Injury": sys.argv[5],
            "Mental": sys.argv[6],
            "Pain": sys.argv[7],
            "Saturation": int(sys.argv[8]),
            "Disposition": sys.argv[9],
            "Length of stay_min": int(sys.argv[10]),
            "New_Age": sys.argv[11],
            "New_SBP": sys.argv[12],
            "New_DBP": sys.argv[13],
            "New_HR": sys.argv[14],
            "New_RR": sys.argv[15],
            "New_BT": sys.argv[16],
            "New_NRS_pain": sys.argv[17],
        }

        # =========================
        # DATAFRAME
        # =========================
        df = pd.DataFrame([input_data])

        # =========================
        # ENCODING
        # =========================
        df_encoded = one_hot_encoder(df, categorical_cols)

        # مطابقة الأعمدة مع التدريب 100%
        df_encoded = df_encoded.reindex(columns=feature_columns, fill_value=0)

        # =========================
        # SCALING (NUMERICAL ONLY)
        # =========================
        numerical_cols = [
            'Patients number per hour',
            'Saturation',
            'Length of stay_min'
        ]
        df_encoded[numerical_cols] = scaler.transform(df_encoded[numerical_cols])

        # =========================
        # PREDICTION
        # =========================
        proba = model.predict_proba(df_encoded)[0]

        CLASS_MAP = {
            0: "Non-Emergency",
            1: "Emergency"
        }

        class_prob = {
            CLASS_MAP[int(cls)]: float(prob)
            for cls, prob in zip(model.classes_, proba)
        }

        predicted_class = max(class_prob, key=class_prob.get)
        probability = class_prob[predicted_class]

        # =========================
        # OUTPUT (ONLY FINAL RESULT)
        # =========================
        print(f"{predicted_class} (Probability: {probability:.2f})")

    except ValueError as e:
        print(f"Data conversion error: {e}", file=sys.stderr)
        sys.exit(1)

    except Exception as e:
        print(f"General error: {e}", file=sys.stderr)
        sys.exit(1)
