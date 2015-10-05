--Ruth-Aaron Pairs, 05 Oct 2015, https://www.reddit.com/r/dailyprogrammer/comments/3nkanm/20151005_challenge_235_easy_ruthaaron_pairs/

--I ignored I/O, and, as you might notice, no main
isPrime :: Int->Bool
isPrime x = ([] == [y | y<-[2..floor (sqrt (fromIntegral x))], mod x y == 0])

primeFactors :: Int -> [Int]
primeFactors n = [x | x <- [2..n], n `mod` x == 0, isPrime x]

test :: Int -> Int -> Bool
test x y = sum (primeFactors x) == sum (primeFactors y)