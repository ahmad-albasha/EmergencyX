import sys
import joblib
import pandas as pd
import io



sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')

# دالة التنبؤ (مستخرجة من الكود السابق)
def predict_heart_disease(input_data):
    """
    تنبؤ بأزمة قلبية بناءً على بيانات الإدخال.
    input_data: قاموس يحتوي على المفاتيح التالية.
    Returns: "مصاب بأزمة قلبية (احتمالية: X.XX)" أو "غير مصاب (احتمالية الإصابة: X.XX)"
    """
    # تحميل النموذج (افترض أن الملف موجود في نفس المجلد)
    model = joblib.load('heart_disease_model.pkl')
    
    # تحويل البيانات إلى DataFrame
    input_df = pd.DataFrame([input_data])
    
    # التنبؤ
    prediction = model.predict(input_df)[0]
    probability = model.predict_proba(input_df)[0][1]  # احتمال الإصابة
    
    if prediction == 1:
        return f"مصاب بأزمة قلبية (احتمالية: {probability:.2f})"
    else:
        return f"غير مصاب (احتمالية الإصابة: {probability:.2f})"

# الجزء الرئيسي: قراءة الوسائط من سطر الأوامر
if __name__ == "__main__":
    # الوسائط المتوقعة: age sex cp trtbps chol fbs restecg thalachh exng oldpeak slp caa thall
    # يجب أن تكون 13 وسيطة (بالإضافة إلى اسم السكريبت)
    if len(sys.argv) != 14:
        print("خطأ: عدد الوسائط غير صحيح. يجب تمرير 13 قيمة.")
        sys.exit(1)
    
    try:
        # تحويل الوسائط إلى قاموس
        input_data = {
            'age': int(sys.argv[1]),
            'sex': int(sys.argv[2]),
            'cp': int(sys.argv[3]),
            'trtbps': int(sys.argv[4]),
            'chol': int(sys.argv[5]),
            'fbs': int(sys.argv[6]),
            'restecg': int(sys.argv[7]),
            'thalachh': int(sys.argv[8]),
            'exng': int(sys.argv[9]),
            'oldpeak': float(sys.argv[10]),
            'slp': int(sys.argv[11]),
            'caa': int(sys.argv[12]),
            'thall': int(sys.argv[13])
        }
        
        # استدعاء الدالة وطباعة النتيجة
        result = predict_heart_disease(input_data)
        print(result)
    
    except ValueError as e:
        print(f"خطأ في تحويل البيانات: {e}")
        sys.exit(1)
    except Exception as e:
        print(f"خطأ عام: {e}")
        sys.exit(1)