# -*- coding: utf-8 -*-
import tensorflow as tf
import numpy as np
import pandas as pd
from sklearn.preprocessing import StandardScaler

'''
ANN example data format:
male (binary - int64): indicates gender
BPMeds (binary - int64): 1 if patient is using blood pressure medication
prevalentHyp (binary- int64): 1 if patient has prevalent Hypertension
diabetes (binary - int64): 1 if patient has diabetes
age (int64): patient's age
cigsPerDay (int64): number of cigarettes that the patient is using daily
                    0 for none
totChol (float64): total cholestrol
sysBP (float64): systolic blood pressure of patient
diaBP (float64): diastolic blood pressure of patient
glucose (float64): current glucose levels of patient

'''

def prepare(filepath):
    image = tf.keras.preprocessing.image.load_img(filepath, 
                                                  target_size = (64,64))
    input_arr = tf.keras.preprocessing.image.img_to_array(image)
    input_arr = np.array([input_arr])
    return input_arr

df = pd.read_csv("C:\Civan\db.civan", sep = "$")
data = df.iloc[:, 0].values

if data == 1:
    dat = pd.read_csv('training_set/heart_disease.csv')
    X = dat.drop(['education', 'BMI', 'prevalentStroke', 'heartRate',
             'currentSmoker' ],
            axis = 1, inplace = True)
    dat = dat[['male', 'BPMeds', 'prevalentHyp', 'diabetes', 
         'age', 'cigsPerDay', 'totChol', 'sysBP', 
         'diaBP', 'glucose']]
    X = dat.iloc[:,0:10].values
    sc = StandardScaler()
    X_1 = sc.fit(X)
    X = sc.transform(X)
    df = df[['Gender', 'BPMeds', 'hyp','diabetes', 'age',
             'cigsPerDay', 'totChol', 'sysBP', 
             'diaBP', 'glucose']]
    df = df.iloc[:].values
    ann = tf.keras.models.load_model("ANN_heart_disease.model")
    df = sc.transform(df)
    w_instance = ann.predict(df)
    w_instance = (w_instance > 0.5)
    if w_instance[0][0] == 1:
        prediction = "positive"
    else:
        prediction = "negative" 
    
    f = open("C:/Civan/res.civan", "w")
    f.write(prediction)
    f.close()

else:
    image_name = df['photo_name'].iat[0]  
    image_name = image_name[0]
    image = prepare(f'C:/Civan/images/{image_name}')
    cnn = tf.keras.models.load_model("CNN_covid_pred.model")
    result = cnn.predict([image])
    if result[0][0] == 1:
        prediction = "positive"
    else:
        prediction = "negative" 
    
    f = open("C:/Civan/res.civan", "w")
    f.write(prediction)
    f.close()
    