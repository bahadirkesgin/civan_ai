# -*- coding: utf-8 -*-
import tensorflow as tf
import numpy as np
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
#TODO: input mechanic (both)
ann = tf.keras.model.load_model("ANN_heart_disease.model")
sc = StandardScaler()
w_instance = ann.predict(sc.transform(
        np.array([[1, 0, 0, 0, 24, 4, 180, 110, 80, 75]])))#example
w_instance = (w_instance > 0.5)


def prepare(filepath):
    image = tf.keras.preprocessing.image.load_img(filepath, 
                                                  input_size = (64,64))
    input_arr = tf.keras.preprocessing.image.img_to_array(image)
    input_arr = np.array([input_arr])
    return input_arr

#TODO: image input mechanic (both)
cnn = tf.keras.models.load_model("CNN_covid_pred.model")
result = cnn.predict([prepare('datasets/training_set/negative/nCT26.jpg')])

if result[0][0] == 1:
    prediction = 'positive'
else:
    prediction = 'negative' 