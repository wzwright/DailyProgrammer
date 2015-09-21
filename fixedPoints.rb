# The Dottie Number, 24 Aug 2015, https://www.reddit.com/r/dailyprogrammer/comments/3i99w8/20150824_challenge_229_easy_the_dottie_number/
# Calculating fixed points of various functions
# This could have been more elegantly done with Proc, but I didn't think of it before I finished this version
def dottie
    current=1
    previous=-10
    until (current-previous).abs<0.000001
        previous=current
        current=Math.cos(current)
    end
    return current
end

def pi
    current=2
    previous=-10
    until (current-previous).abs<0.000001
        previous=current
        current=current-Math.tan(current)
    end
    return current
end

def goldenRatio
    current=1.0
    previous=-10.0
    until (current-previous).abs<0.000001
        previous=current
        current=1.0+1.0/current        
    end
    return current
end

def logisticMap
    current=0.75
    previous=-10.0
    until (current-previous).abs<0.000001
        previous=current
        current=4*current*(1-current)        
    end
    return current
end