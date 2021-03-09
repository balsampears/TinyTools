import time
import random

from config.config import DefaultConfig
from utils.DmUtils import DmUtils


class FinderUtils:
    @staticmethod
    def moveAndClick(rect, isDefinePos=False):
        if isDefinePos:  # 格式 （x，y）
            DmUtils.moveTo(rect)
        else:  # 格式 （（x,y），（x,y））
            DmUtils.moveTo(FinderUtils.__getRandPos(rect))
        time.sleep(DefaultConfig.sleepTime)
        DmUtils.leftClick()
        time.sleep(DefaultConfig.sleepTime)

    @staticmethod
    def __getRandPos(rect):
        x = random.randint(rect[0][0], rect[1][0])
        y = random.randint(rect[0][1], rect[1][1])
        # print("随机到的位置",(x,y))
        return x, y

    # 总是返回找到图片的坐标和范围
    @staticmethod
    def search(picName, findNum=DefaultConfig.findOnePicTime, confidence=None):
        for i in range(findNum):
            rect = DmUtils.findTarget(picName, confidence)
            if rect is not None:
                print("成功找到了", picName)
                return rect
            else:
                if findNum != 1:  # 要是只找一次的话就不要等待了
                    time.sleep(DefaultConfig.sleepTime)
                    print("第", i + 1, "次寻找", picName)
        return None
