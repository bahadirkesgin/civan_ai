# -*- coding: utf-8 -*-
from keras.wrappers.scikit_learn import Kerasmodel
from sklearn.model_selection import GridSearchCV
from keras.models import Sequential
from keras.layers import Dense
class ANN(object):
    '''
    ANN neural network class n/
    Hyperparameters List: n/
    modelname (str): Name of the model n/
    x_train (array): Variables of training set n/
    y_train (array): Categorical data of training set n/
    optimizer (str) (default = 'adam') n/
    loss_function (str) (default = 'binary_crossentropy') n/
    n_epoch (int): Number of epochs (default = 150) n/
    batch_size (int): Batch size(default = 32) n/
    
    You have to create a named tuple of hyperparameters and input all of the values
    '''
    def __init__(self, hps):
        self.model = Sequential()
        self.hps = hps
        self.optimizer = self.hps.optimizer

    def build_model(self, hps, optimizer = 'adam'):
        '''
        Builds and returns CNN-RNN neural network. n/ 
        Used hyperparameters list: n/
            optimizer (str)(default = 'adam') n/
            loss_function (str) (default = 'binary_crossentropy) n/
            dropout_rate (float) (default = 0.2) n/
            input_dim (int): input dimension 
        '''
        self.model.add(Dense(units = 60,kernel_initializer = 'uniform', 
                             activation = 'relu'))
        self.model.add(Dense(units = 60,kernel_initializer = 'uniform', 
                             activation = 'relu'))
        self.model.add(Dense(units = 60,kernel_initializer = 'uniform', 
                             activation = 'relu'))
        self.model.add(Dense(units = 60,kernel_initializer = 'uniform', 
                             activation = 'relu'))#48
        self.model.add(Dense(units = 1 ,kernel_initializer = 'uniform',
                             activation = 'sigmoid'))
        self.model.compile(optimizer = optimizer, 
                           loss = self.hps.loss_function,
                           metrics = ['accuracy'])
        return self.model
      
    def train_model(self):
        '''
        Reshapes your dataframe and trains your CNN-RNN model. n/
        Can't work unless you build your model using ceratin function. n/
        Used hyperparameters: n/
            x_train (array): Variables of training set n/
            y_train (array): Categorical data of training set n/
            n_epoch (int): Number of epochs (default = 150) n/,
            batch_size (int): Batch size(default = 32)
        '''
        modelname = self.hps.modelname
        self.x_train = self.hps.x_train
        self.y_train = self.hps.y_train
        self.model.fit(self.x_train, self.y_train,
                       batch_size = self.hps.batch_size,
                       epochs = self.hps.n_epoch)
        self.model.save(f'ANN_{modelname}.model')
        return self.model
    
    def tune_model(self):
        '''
        
        '''
        model = Kerasmodel(build_fn = self.build_model)
        parameters = {'batch_size': [25, 32],
                      'epochs': [100, 150],
                      'optimizer': ['adam', 'RMSprop']}
        grid_search = GridSearchCV(estimator = model,
                                   param_grid = parameters,
                                   scoring = 'accuracy',
                                   cv = 10)
        grid_search = grid_search.fit(self.hps.x_train,
                                      self.hps.y_train)
        best_params = grid_search.best_params_
        best_acc = grid_search.best_score_
        return best_params , best_acc