from glob import glob
from os import walk


path = '../a2-coursework'


def main():
#    for (dirpath, dirnames, filenames) in walk(path):
#        print(filenames)

    for file in glob(path + '*.cs', recursive=True):
        print(filename)


if __name__ == '__main__':
    main()
