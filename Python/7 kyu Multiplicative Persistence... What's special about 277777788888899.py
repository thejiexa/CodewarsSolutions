import codewars_test as test
from math import prod

def per(n):
    list = []
    while n > 9:
        n = prod(map(int, str(n)))
        list.append(n)

    return list

test.assert_equals(per(1), [])
test.assert_equals(per(10), [0])
test.assert_equals(per(69), [54, 20, 0])
test.assert_equals(per(277777788888899), [4996238671872, 438939648, 4478976, 338688, 27648, 2688, 768, 336, 54, 20, 0])