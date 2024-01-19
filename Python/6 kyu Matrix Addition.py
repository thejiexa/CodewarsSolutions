import codewars_test as test
import numpy as np

matrix_addition = lambda a, b: (np.array(a) + np.array(b)).tolist()

# def matrix_addition(a, b):
#    return [[a[i][j] + b[i][j]  for j in range
#     (len(a[0]))] for i in range(len(a))]

test.assert_equals(matrix_addition(
[ [1, 2],
    [1, 2] ],
#     +
[ [2, 3],
    [2, 3] ] ),
#     =
[ [3, 5],
    [3, 5] ] )

test.assert_equals(matrix_addition(
[ [1] ],
#    +
[ [2] ] ),
#    =
[ [3] ] )

test.assert_equals(matrix_addition(
[ [1, 2, 3],
    [3, 2, 1],
    [1, 1, 1] ],
#       +
[ [2, 2, 1],
    [3, 2, 3],
    [1, 1, 3] ] ),
#       =
[ [3, 4, 4],
    [6, 4, 4],
    [2, 2, 4] ] )