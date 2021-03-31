#dfsdf
import splitfolders as sp
sp.ratio('datasets/covid-19', output = 'datasets/covid_splitted',
         seed=1337, ratio = (.8,.2), group_prefix=None)