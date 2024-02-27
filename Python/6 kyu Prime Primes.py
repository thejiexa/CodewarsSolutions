import codewars_test as test

def is_prime(n):
    if n <= 1:
        return False
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True

def prime_primes(N):
    primes = [i for i in range(2, N) if is_prime(i)]
    prime_primes = [primes[i] / primes[j] for i in range(len(primes)) for j in range(i+1, len(primes)) if primes[i] / primes[j] < 1]        
    return (len(prime_primes), int(sum(prime_primes)))

@test.describe("Prime Primes")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(prime_primes(6), (3, 1))
        test.assert_equals(prime_primes(4), (1, 0))