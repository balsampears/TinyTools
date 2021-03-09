from core.AssiCounter import AssiCounter
from core.AssiModule import AssiModule
from utils.FinderUtils import FinderUtils


class Adventure(AssiModule):

    def __init__(self):
        self.name: str = "冒险"
        self.counter = AssiCounter()
        super().__init__(self.name, self.counter)

    def check1(self):
        return FinderUtils.search("34")

    def action1(self, rect):
        FinderUtils.moveAndClick(rect)

    def check2(self):
        return FinderUtils.search("choiceTeam")

    def action2(self, rect):
        FinderUtils.moveAndClick(rect)

    def check3(self):
        return FinderUtils.search("run")

    def action3(self, rect):
        FinderUtils.moveAndClick(rect)
