import os
import subprocess

directory = 'cd /c/Dev/Data-Structures-Algorithms'
cm = 'git log'

log = open("git_change_log.txt", "w")
log.write("=======Git Change Log=========\n")
subprocess.Popen(cm, stdout=log)

log.close()