import abc


from core import AssiCounter
from core.AssiStructure import AssiStructure


class AssiModule:
    # 抽象类定义
    __metaclass__ = abc.ABCMeta

    _MAXFUNCTION = 10
    _PRECHECKNAME = "check"
    _PREWORKNAME = "action"

    def __init__(self, name: str, counter: AssiCounter = None):
        super().__init__()
        self.name = name
        self.counter = counter
        self.checkHandle = AssiStructure(self, AssiModule._PRECHECKNAME, AssiModule._MAXFUNCTION)
        self.workHandle = AssiStructure(self, AssiModule._PREWORKNAME, AssiModule._MAXFUNCTION)

    # 接口函数，完成模块所有内容时运行
    def handleForEnd(self):
        if self.name is not None:
            print("【", self.name, "】模块已经完成所有任务。。。")

    # 接口函数，刚进入模块，可能是错误进来
    def handleForBegin(self):
        if self.name is not None:
            print("【", self.name, "】模块已经启动。。。")

    def _setHand(self, index):
        self.checkHandle.hand = index
        self.workHandle.hand = index

    def run(self, stageId=None, advTotal=None):
        """
        运行模块
        :param stageId: 从哪个阶段场景开始
        :param advTotal: 进行多少次冒险
        :return:
        """
        self.handleForBegin()

        if stageId is not None:
            self._setHand(stageId)
        if advTotal is not None:
            self.counter.total = advTotal

        while True:
            parameters = self.checkHandle.next()
            # 当所有的check函数都运行完
            if parameters == -1:
                # 当存在计数器时，没到目标次数会重置指针全部重新执行一次
                if self.counter is None or self.counter.now >= self.counter.total - 1:
                    self.handleForEnd()
                    return True
                self.counter.now = self.counter.now + 1
                self._setHand(0)
                continue
            # 当找不到当前场景时
            elif parameters is None:
                return False

            self.workHandle.next(parameters)
