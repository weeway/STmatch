import os
import sys
import getopt


def get_config():
    shortopts = 's:t:l'
    longopts = ['students-num', "teacher-num"]

    config = {}

    optlist, args = getopt.getopt(sys.argv[1:], shortopts, longopts)
    try:
        for key, value in optlist:
            if key == '-s':
                config['stu'] = int(value)
            elif key == '-t':
                config['tea'] = int(value)
    except getopt.GetoptError as e:
        print_help()
    return config


def print_help():
    print('''usage: match [OPTION]...
Options:
  -s NUM_OF_STUDENTS        number of students
  -t NUM_OF_TEACHERS        number of teachers
  -h help                   print help
''')
