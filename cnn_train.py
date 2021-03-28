# -*- coding: utf-8 -*-
import tensorflow as tf
from collections import namedtuple
from cnn import CNN
hps = namedtuple('hps', ['modelname',
                         'training_set_dir',
                         'test_set_dir',
                         'optimizer',
                         'loss_function',
                         'n_epoch',
                         'dropout_rate',
                         'steps_per_epoch',
                         'validation_steps',
                         'input_shape'])

def hps_set():
    return hps(modelname = 'covid_pred',
               training_set_dir = 'datasets/covid_splitted/train',
               test_set_dir = 'datasets/covid_splitted/val',
               optimizer = 'adam',
               loss_function = 'binary_crossentropy',
               n_epoch = 25,
               dropout_rate = 0.2,
               steps_per_epoch = 10800,
               validation_steps = 2700,
               input_shape = (64,64,3))

hps = hps_set()
predictor = CNN(hps)
predictor.build_model(hps)
predictor.train_model()
model = tf.keras.models.load_model("CNN_covid_pred.model")
#instance = predictor.reshape_instance(
#        data_dir = 'datasets/covid_test/negative/nCT122.jpg')
#result = model.predict(instance)
#if result[0][0] == 1:
#    prediction = 'positive'
#else:
#    prediction = 'negative'
