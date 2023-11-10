import pandas as pd
import numpy as np
train = pd.read_csv('train.csv')

txt_writer = open('train_aug.txt', 'w')

for i in range(train.shape[0]):
    txt_writer.write(train['ImageId'].iloc[i][:-4] + '\n')
txt_writer.close()
