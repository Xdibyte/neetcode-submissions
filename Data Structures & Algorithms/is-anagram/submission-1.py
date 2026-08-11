class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        alphabet = [0] * 26
        for i in range(len(s)):
            j = ord(s[i]) - 97
            alphabet[j] = alphabet[j] + 1
        for i in range(len(t)):
            j = ord(t[i]) - 97
            alphabet[j] = alphabet[j] - 1
        for i in range(len(alphabet)):
            if alphabet[i] != 0:
                return False
        return True
        