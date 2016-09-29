"""
generate data for STmatch

毕设导师智能匹配
1、30个导师
2、每个导师所带学生数[0,8]
3、100个学生
4、每个学生有五个导师志愿
"""
import random


class Teacher(object):
    def __init__(self, name, n, i):
        self.i = i
        self.n = n
        self.name = name

    def __repr__(self):
        return "{} {}" \
            .format(self.name,
                    self.n)


class Student(object):
    def __init__(self, name, i, *vols):
        self.name = name
        self.list = list(*vols)
        self.i = i

    def __repr__(self):
        return "{} {}" \
            .format(self.name,
                    self.list)


def gen_teas(n):
    Tchs = list()
    for i in range(1, n + 1):
        Tchs.append(Teacher(rand_name(), \
                            random.randint(0, 8), i))

    return Tchs


def gen_vols(n):
    vols = list()
    for i in range(5):
        vols.append(random.randint(1, n))

    return vols


def gen_stus(n, m):
    Stus = list()
    for i in range(1, n + 1):
        Stus.append(Student(rand_name(), i, \
                            gen_vols(m)))

    return Stus


def rand_name():
    name = chr(random.randint(65, 90))
    len = random.randint(3, 6)
    for i in range(len):
        name += chr(random.randint(97, 122))

    return name
