# Sad Cycles, 18 May 2015, https://www.reddit.com/r/dailyprogrammer/comments/36cyxf/20150518_challenge_215_easy_sad_cycles/
def sadCycle(base, start):
    cycle=[]
    next=start
    while next not in cycle:
        cycle.append(next)
        after=0
        for c in str(next):
            after+=int(c)**base
        next=after
    print(", ".join([str(s) for s in cycle[cycle.index(next):]]))