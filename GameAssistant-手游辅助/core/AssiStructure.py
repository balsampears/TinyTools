
# 一种通过反射调用一系列 前缀名+数字 命名的函数的实现类
# 通过next、pre函数进行调用，没有目标函数返回-1
class AssiStructure:
    hand = 0
    target = None
    preFuncName = "func_"
    maxFuncNum = 50

    def __init__(self, target, preFuncName=None, maxFuncNum=None):
        super().__init__()
        self.target = target
        if preFuncName is not None:
            self.preFuncName = preFuncName
        if maxFuncNum is not None:
            self.maxFuncNum = maxFuncNum

    def next(self, args=None):
        self.hand = self.hand + 1
        return self.execute(args)

    def pre(self, args=None):
        self.hand = self.hand - 1
        return self.execute(args)

    def execute(self, args):
        funcName = self.preFuncName + str(self.hand)
        # 当存在对应的方法时，调用该方法，否则返回-1
        if hasattr(self.target.__class__, funcName):
            func = getattr(self.target.__class__, funcName)
            # try:
            if args is not None:
                ret = func(self.target, args)
                return ret
            else:
            # except TypeError:
                ret = func(self.target)
                return ret
        return -1
