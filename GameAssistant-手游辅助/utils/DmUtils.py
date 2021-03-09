import operator
import win32api
import win32gui

import win32con
from PIL import ImageGrab, Image    # 图像识别
import cv2 as cv                    # 图片处理

from config.config import DefaultConfig


class DmUtils:

    handle = None
    basePic = '../../images/'

    # 初始化操作
    @classmethod
    def setHandle(cls, handle):
        cls.handle = handle

    # 消息提示
    @classmethod
    def messageBox(cls, hwnd, content, title):
        win32api.MessageBox(0, hwnd, content, title)

    # 窗体操作
    @classmethod
    def findWindow(cls, windowName, className=None):
        return win32gui.FindWindow(className, windowName)

    @classmethod
    def setForegroundWindow(cls, handle):
        return win32gui.SetForegroundWindow(handle)

    @classmethod
    def setWindowPos(cls, handle, x, y):
        rect = cls.getWindowRect(handle)
        win32gui.MoveWindow(handle, x, y, rect[2] - rect[0], rect[3] - rect[1], True)

    @classmethod
    def getWindowRect(cls, handle):
        return win32gui.GetWindowRect(handle)  # 返回(left, top, right, bottom)

    @classmethod
    def setWindow(cls, handle, x, y, w, h):
        win32gui.MoveWindow(handle, x, y, w, h, True)

    @classmethod
    def getCursorPos(cls):
        return win32api.GetCursorPos()

    @classmethod
    def setCursorPos(cls, x, y):
        win32api.SetCursorPos([x, y])

    @classmethod
    def moveTo(cls, pos):
        print(pos)
        win32api.mouse_event(win32con.MOUSEEVENTF_MOVE, pos[0], pos[1], 0, 0)

    @classmethod
    def leftClick(cls):
        mPos = cls.getCursorPos()
        win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN, mPos[0], mPos[1], 0, 0)
        win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP, mPos[0], mPos[1], 0, 0)

    @classmethod
    def rightClick(cls):
        mPos = cls.getCursorPos()
        win32api.mouse_event(win32con.MOUSEEVENTF_RIGHTDOWN, mPos[0], mPos[1], 0, 0)
        win32api.mouse_event(win32con.MOUSEEVENTF_RIGHTUP, mPos[0], mPos[1], 0, 0)

    @classmethod
    def grab(cls, lx=0, ly=0, rx=0, ry=0):
        """
        在全屏指定范围，抓取图片
        :return:
        """
        return ImageGrab.grab() if (lx == 0 and ly == 0 and rx == 0 and ry == 0) else ImageGrab.grab((lx, ly, rx, ry))

    # 汉明距离比较图片是否相同
    @classmethod
    def isMatch(self, im1, im2):
        image1 = im1.resize((20, 20), Image.ANTIALIAS).convert("L")
        image2 = im2.resize((20, 20), Image.ANTIALIAS).convert("L")
        pixels1 = list(image1.getdata())
        pixels2 = list(image2.getdata())
        avg1 = sum(pixels1) / len(pixels1)
        avg2 = sum(pixels2) / len(pixels2)
        hash1 = "".join(map(lambda p: "1" if p > avg1 else "0", pixels1))
        hash2 = "".join(map(lambda p: "1" if p > avg2 else "0", pixels2))
        match = sum(map(operator.ne, hash1, hash2))
        return match < 10

    @classmethod
    def findPic(cls, im, bigIm, confidence=None):
        """
        在指定图片内寻找特定图片
        :param im:          待寻找的图片
        :param bigIm:       范围图片
        :param confidence:  相似度
        :return:
        """
        im2 = cv.imread(im, 0)
        bigIm2 = cv.imread(bigIm, 0)
        res = cv.matchTemplate(im2, bigIm2, cv.TM_CCOEFF_NORMED)
        min_val, max_val, min_loc, max_loc = cv.minMaxLoc(res)
        if confidence is None:
            confidence = DefaultConfig.confidence
        if max_val > confidence:
            pos = max_loc
        else:
            return None
        # print(min_val, max_val, min_loc, max_loc )
        # DmUtils.moveTo(left_pos)
        h, w = im2.shape[0], im2.shape[1]
        return pos, (pos[0] + w, pos[1] + h)

    @classmethod
    def findTarget(cls, im, confidence=None):
        """
        在全屏范围查找特定的图片
        :param im:              图片路径
        :param confidence:      相似度
        :return:
        """
        if cls.handle is None:
            bigIm = cls.grab()
        else:
            rect = cls.getWindowRect(cls.handle)
            bigIm = cls.grab(rect[0], rect[1], rect[2], rect[3])
        bigIm.save(cls.basePic + "tmp.jpg")
        im = cls.basePic + im + ".jpg"
        bigIm2 = cls.basePic + "tmp.jpg"
        return cls.findPic(im, bigIm2, confidence)
