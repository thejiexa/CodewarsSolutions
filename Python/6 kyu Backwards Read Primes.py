import codewars_test as test

def is_prime(n):
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True

reverse = lambda n: int(''.join(str(n)[::-1]))

backwards_prime = lambda start, stop: [i for i in range(start, stop + 1) if is_prime(i) and is_prime(reverse(i)) and i != reverse(i)]

# def backwards_prime(start, stop):
#     list = []
#     for i in range(start, stop + 1):
#         if is_prime(i) and is_prime(reverse(i)) and not i == reverse(i):
#             list.append(i)

#     return list

@test.describe('Tests')
def fixed_tests():
    def testing(n, m, exp):
        # so already passed solutions with camelCase name are not invalidated
        try:
            actual = backwardsPrime(n, m)
        except NameError:
            actual = backwards_prime(n, m)
        test.assert_equals(actual, exp)
        
    @test.it('Basic Tests')
    def basic_tests1():
        a1 = [13, 17, 31, 37, 71, 73, 79, 97]
        testing(1, 97, a1)  
        a1 = [7027, 7043, 7057]
        testing(7000, 7100, a1)  
        a8 = []
        testing(400, 503, a8)