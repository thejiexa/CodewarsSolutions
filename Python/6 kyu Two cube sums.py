import codewars_test as test

def has_two_cube_sums(n):
    list = []

    for x in range(1, 210):
        for y in range(1, x):
            if x**3 + y**3 == n and x != y and x not in list and y not in list:
                list.append(x)
                list.append(y)
                if (len(list) > 3): return True
            
    return False

test.assert_equals(has_two_cube_sums(1), False)
test.assert_equals(has_two_cube_sums(1729),True) # 9^3 + 10^3 and 1^3 + 12^3
test.assert_equals(has_two_cube_sums(42), False)
test.assert_equals(has_two_cube_sums(4104), True)
test.assert_equals(has_two_cube_sums(4105), False)