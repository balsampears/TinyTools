from utils.DmUtils import DmUtils
from webapps.module.AdvModule import Adventure

adv = Adventure()
dm = DmUtils()

if __name__ == '__main__':
    adv.run(None, 5)