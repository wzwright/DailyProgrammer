# Palindromes, 14 Sep 2015, https://www.reddit.com/r/dailyprogrammer/comments/3kx6oh/20150914_challenge_232_easy_palindromes/

# Remarkably simple with Python
def palindrome(text):
    return (lambda s: s==s[::-1])("".join(c for c in text if c.isalpha()))