# -*- coding: utf-8 -*-
import cv2
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

#TODO: adjust reshaping (bahadır)
def prepare(filepath):
    IMG_SIZE = 70  # 50 in txt-based
    img_array = cv2.imread(filepath, cv2.IMREAD_GRAYSCALE)  # read in the image, convert to grayscale
    new_array = cv2.resize(img_array, (IMG_SIZE, IMG_SIZE))  # resize image to match cnn's expected sizing
    return new_array.reshape(-1, IMG_SIZE, IMG_SIZE, 1)  # return the image with shaping that TF wants.

cnn = tf.keras.models.load_model("CNN_covid_pred.model")
result = cnn.predict([prepare('dataset/training_set/negative/nCT26.jpg')])

if result[0][0] == 1:
    prediction = 'positive'
else:
    prediction = 'negative' 