# Fibonacci-ish Sequence, 14 Oct 2015, https://www.reddit.com/r/dailyprogrammer/comments/3opin7/20151014_challenge_236_intermediate_fibonacciish/

def fibonacciish(i):
    fib = [0, 1]
    while(fib[-1]<i):
        fib.append(fib[-1]+fib[-2])
    for x in reversed(range(len(fib))):
        if i%fib[x]==0:
            fib=list(map(lambda a: a*i/fib[x],fib))
            print(" ".join(str(int(a)) for a in fib[:fib.index(i)+1]))
            return
