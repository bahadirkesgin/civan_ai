# -*- coding: utf-8 -*-
import tensorflow as tf
import numpy as np
import pandas as pd
from collections import namedtuple
from ann import ANN
from sklearn.metrics import confusion_matrix
hps = namedtuple('hps', ['modelname',
                         'x_train',
                         'y_train',
                         'optimizer',
                         'loss_function',
                         'n_epoch',
                         'batch_size',
                         'input_dim'])
df = pd.read_csv('datasets/heart_disease.csv')
X = df.drop(['education', 'BMI', 'prevalentStroke', 'heartRate',
             'currentSmoker' ],
            axis = 1, inplace = True)
df = df[['male', 'BPMeds', 'prevalentHyp', 'diabetes', 
         'age', 'cigsPerDay', 'totChol', 'sysBP', 
         'diaBP', 'glucose', 'TenYearCHD']]
X = df.iloc[:,0:10].values
y = df.iloc[:, 10].values

from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size = 0.2, random_state = 0)

from sklearn.preprocessing import StandardScaler
sc = StandardScaler()
X_train[:, 4:] = sc.fit_transform(X_train[:, 4:])
X_test[:, 4:] = sc.transform(X_test[:, 4:])

from sklearn.impute import SimpleImputer
ip = SimpleImputer(missing_values = np.nan, strategy = 'mean')
ip.fit(X_train)
ip.fit(X_test)
X_train = ip.transform(X_train)
X_test = ip.transform(X_test)

def hps_set():
    return hps(modelname = 'heart_disease',
               x_train = X_train,
               y_train = y_train,
               optimizer = 'RMSprop',
               loss_function = 'binary_crossentropy',
               n_epoch = 100, #30
               batch_size = 36,
               input_dim = 10)

hps = hps_set()
predictor = ANN(hps)
predictor.build_model(hps = hps, optimizer = hps.optimizer)
predictor.train_model()
#predictor.tune_model()
model = tf.keras.models.load_model("ANN_heart_disease.model")
y_pred = model.predict(X_test)
y_pred = sc.fit_transform(y_pred)
y_pred = (y_pred > 0.5)
cm = confusion_matrix(y_test, y_pred)
print(cm)