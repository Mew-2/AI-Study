import os
import cv2 
import numpy as np


################################
# --- Variables ---
################################
IMAGE_SIZE = (500, 500)

# -- Threshold Details --
# *THRESHOLD_VALUE:需要根据数据来实验一下
THRESHOLD_VALUE = 130
MAX_VALUE = 255

# -- Invert Threshold Details --
INV_THRESHOLD_VALUE = 50
INV_MAX_VALUE = 255

# -- Canny Details --
THRESHOLD1 = 100
THRESHOLD2 = 70

# --contour properties--
CON_COLOR = (0, 0, 255)
CON_THICKNESS = 1

# -- 字体颜色--
WHITE = (255, 255, 255)
BLACK = (0, 0, 0)
GREEN = (0, 255, 0)
RED = (0, 0, 255)
STACK_IMG_SIZE = (200, 200)

################################
file = 's2.JPG'
path = 'images/' + file

# 1:读数据
imageOri = cv2.imread(path)
#print(imageOri)

# 2：灰度图
image = cv2.cvtColor(imageOri,cv2.COLOR_BGR2GRAY)
#cv2.imshow('image_gray',image)
#cv2.waitKey(0)
#cv2.destroyAllWindows()

# 3:resize
imageOri = cv2.resize(imageOri,IMAGE_SIZE)
image = cv2.resize(image,IMAGE_SIZE)

# 4:THRESHOLD操作
ret,thresh_basic = cv2.threshold(image,THRESHOLD_VALUE,MAX_VALUE,cv2.THRESH_BINARY)

# 5:形态学操作
kernel = np.ones((3,3),np.uint8)
img_erosion = cv2.erode(thresh_basic,kernel,iterations=1)

ret, thresh_inv = cv2.threshold(img_erosion,INV_THRESHOLD_VALUE,INV_MAX_VALUE,cv2.THRESH_BINARY_INV)

# 6:Canny边缘检测
edged = cv2.Canny(img_erosion,THRESHOLD1,THRESHOLD2)

# 7:轮廓
contours,h = cv2.findContours(thresh_inv,cv2.RETR_EXTERNAL,cv2.CHAIN_APPROX_NONE)


    # ++++++++++++++++++
    # -- Image Stack  --
    # ++++++++++++++++++
font = cv2.FONT_HERSHEY_SIMPLEX

imageRz = cv2.resize(image, STACK_IMG_SIZE)
thresh_basicRz = cv2.resize(thresh_basic, STACK_IMG_SIZE)
img_erosionRz = cv2.resize(img_erosion, STACK_IMG_SIZE)
thresh_invRz = cv2.resize(thresh_inv, STACK_IMG_SIZE)
edgedRz = cv2.resize(edged, STACK_IMG_SIZE)

imageRz = cv2.putText(imageRz, 'GrayScale', (5, 15), font, 0.5, WHITE, 1, cv2.LINE_AA)
thresh_basicRz = cv2.putText(thresh_basicRz, 'ThresholdBasic', (5, 15), font,
                             0.5, WHITE, 1,cv2.LINE_AA)
img_erosionRz = cv2.putText(img_erosionRz, 'Morphology-Erosion', (5, 15), font,
                            0.5, WHITE, 1, cv2.LINE_AA)
thresh_invRz = cv2.putText(thresh_invRz, 'Threshold-mode INV', (5, 15), font,
                           0.5, BLACK, 1, cv2.LINE_AA)
edgedRz = cv2.putText(edgedRz, 'Canny Edges', (5, 15), font, 0.5, WHITE, 1, cv2.LINE_AA)

numpy_horizontal_concat = np.concatenate((imageRz, thresh_basicRz, img_erosionRz,
                                          thresh_invRz, edgedRz), axis=1)

cv2.imshow('Filtering...', numpy_horizontal_concat)

# +++++++

# get total contours
num_of_con = str(len(contours) - 1)
print("Number of Contours found = " + num_of_con)
if len(contours) > 1:
    print('======================================')
    print('=       MARKINGS DETECTED            =')
    print('======================================\n\n')

# show original img
#cv2.imshow('Original Image', imageOri)
# draw contours on original img
if int(num_of_con) != 0:
    for i in range(int(num_of_con)):
        highlighted_img = cv2.drawContours(imageOri, contours, i, CON_COLOR, CON_THICKNESS)

    highlighted_img = cv2.putText(highlighted_img, 'Approximately {} defect(s) detected'.
                                  format(num_of_con), (5, 15),
                                  font, 0.5, GREEN, 1, cv2.LINE_AA)
else:
    highlighted_img = cv2.putText(imageOri, 'Unable to detect defects!',
                                  (5, 15), font, 0.5, RED, 2, cv2.LINE_AA)

# show markings highlighted img
cv2.imshow('Highlighted Defect', highlighted_img)
# save image containing highlighted defect
cv2.imwrite('Output Images/{}_DEFECTS_HIGHLIGHTED.jpg'.format(file.split('.')[0]), highlighted_img)
cv2.waitKey(0)
cv2.destroyAllWindows()

