# -*- coding: utf-8 -*-
import numpy as np
from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dense, Flatten
from tensorflow.keras.layers import Conv2D, MaxPooling2D
from keras.preprocessing import image
from keras.preprocessing.image import ImageDataGenerator

class CNN(object):
    '''
    CNN neural network class n/
    Hyperparameters List: n/
    modelname (str): Name of the model n/
    input_shape (tuple): Desired format of input (format: (x,y,3) default: (64,64,3)) n/ 
    training_set_dir (str): Directory of training set n/
    test_set_dir(str): Directory of test set
    optimizer (str) (default = 'adam') n/
    loss_function (str) (default = 'binary_crossentropy') n/
    dropout_rate (float) (default = 0.2) n/
    n_epoch (int): Number of epochs (default = 250) n/
    steps_per_epoch: Number of steps per epoch (int) (default = 8000) n/
    validation_steps: Number of validation steps (int) (default = 2000) n/
    
    You have to create a named tuple of hyperparameters and input all of the values
    '''
    def __init__(self, hps):
        self.model = Sequential()
        self.hps = hps

    def build_model(self, hps):
        '''
        Builds and returns CNN-RNN neural network. n/ 
        Used hyperparameters list: n/
            optimizer (str)(default = 'adam') n/
            loss_function (str) (default = 'binary_crossentropy') n/
            dropout_rate (float) (default = 0.2) n/
        '''
        self.model.add(Conv2D(32, (3, 3), input_shape = (64, 64, 3), 
                              activation = 'relu'))
        self.model.add(MaxPooling2D(pool_size = (2, 2)))
        self.model.add(Conv2D(32, (3, 3), activation = 'relu'))
        self.model.add(MaxPooling2D(pool_size = (2, 2)))
        self.model.add(Flatten())
        self.model.add(Dense(units = 128, activation = 'relu'))
        self.model.add(Dense(units = 1, activation = 'sigmoid'))
        self.model.compile(optimizer = self.hps.optimizer, 
                           loss = self.hps.loss_function, 
                           metrics = ['accuracy'])
        return self.model
    
    def reshape_dataframe(self, is_training_set = True):
        '''
        Reshapes your dataframe. n/
        Parameter: n/
        is_training_set: True for reshaping training set otherwise False (default = = True)
        Used hyperparameters: n/
            training_set_dir (str): Directory of training set n/
            test_set_dir(str): Directory of test set
        '''
        reshaper = ImageDataGenerator(rescale = 1./255,
                                     shear_range = 0.2,
                                     zoom_range = 0.2,
                                     horizontal_flip = True)
        test_reshaper = ImageDataGenerator(rescale = 1./255)
        if is_training_set:
            self.training_set = reshaper.flow_from_directory(self.hps.training_set_dir,
                                                    target_size = (64, 64),
                                                    batch_size = 32,
                                                    class_mode = 'binary')
            
            return self.training_set
        else:
            self.test_set = test_reshaper.flow_from_directory(self.hps.test_set_dir,
                                                    target_size = (64, 64),
                                                    batch_size = 32,
                                                    class_mode = 'binary')
            return self.test_set
        try:
            return self.test_set
        except NameError:
            return self.training_set
    
    def reshape_instance(self, data_dir):
        '''
        Reshapes your instance. Can be used on testing one instance n/
        Used parameters: n/
            data_dir (str): Directory of instance
        '''
        instance = image.load_img(data_dir, target_size = (64, 64))
        instance = image.img_to_array(instance)
        instance = np.expand_dims(instance, axis = 0)
        return instance
    
    def train_model(self):
        '''
        Reshapes your dataframe and trains your CNN-RNN model. n/
        Can't work unless you build your model using ceratin function. n/
        Used hyperparameters: n/
            training_set_dir (str): Directory of training set n/
            test_set_dir(str): Directory of test set n/
            n_epoch (int): Number of epochs (default = 250) n/
            steps_per_epoch: Number of steps per epoch (int) (default = 8000) n/
            validation_steps: Number of validation steps (int) (default = 2000) n/
        '''
        modelname = self.hps.modelname
        self.training_set = self.reshape_dataframe()
        self.test_set = self.reshape_dataframe(is_training_set = False)
        self.model.fit_generator(self.training_set,
                         steps_per_epoch = self.hps.steps_per_epoch,
                         epochs = self.hps.n_epoch,
                         validation_data = self.test_set,
                         validation_steps = self.hps.validation_steps)
        self.model.save(f'CNN_{modelname}.model')
        return self.model