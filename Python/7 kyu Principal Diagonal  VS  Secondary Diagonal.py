import codewars_test as test

def diagonal(matrix):
    primary = sum(matrix[i][i] for i in range(len(matrix)))
    secondary = sum(matrix[i][len(matrix) - i - 1] for i in range(len(matrix)))
    return "Principal Diagonal win!" if primary > secondary else "Secondary Diagonal win!" if primary < secondary else "Draw!"

test.describe("Basic tests")
test.assert_equals(diagonal([ [2,2,2],
                            [4,2,6],
                            [8,8,2] ]), "Secondary Diagonal win!")
test.assert_equals(diagonal([ [2,2,2],
                            [4,2,6],
                            [1,8,2] ]), "Principal Diagonal win!")
test.assert_equals(diagonal([ [1,2,3],
                            [4,5,6],
                            [7,8,9] ]), "Draw!")
test.assert_equals(diagonal([ [1, 2, 2, 5, 1],
                            [4, 1, 6, 1, 1],
                            [1, 8, 5, 6 ,2],
                            [1, 5, 2, 1, 2],
                            [1, 8, 2, 6, 1] ]), "Secondary Diagonal win!")
test.assert_equals(diagonal([ [88, 2, 2, 5, 1, 1, 2, 2, 5, 1],
                            [4, 1, 6, 1, 1, 1, 2, 2, 1, 1],
                            [1, 8, 1, 6 ,2, 1, 2, 1, 5, 1],
                            [1, 5, 2, 1, 2, 1, 1, 2, 5, 1],
                            [1, 8, 2, 6, 1, 1, 2, 2, 5, 1],
                            [1, 2, 2, 5, 1, 1, 2, 2, 5, 1],
                            [1, 2, 2, 1, 1, 1, 1, 2, 5, 1],
                            [1, 2, 1, 5, 1, 1, 2, 1, 5, 1],
                            [1, 1, 2, 5, 1, 1, 2, 2, 1, 1],
                            [88, 2, 2, 5, 1, 1, 2, 2, 5, 1] ]), "Draw!")
test.assert_equals(diagonal([ [2,2,2],
                            [4,2,6],
                            [1,8,2] ]), "Principal Diagonal win!")
test.assert_equals(diagonal([ [1, 2, 2, 5, 1],
                            [4, 1, 6, 1, 1],
                            [1, 8, 5, 6 ,2],
                            [1, 5, 2, 1, 2],
                            [1, 8, 2, 6, 1] ]), "Secondary Diagonal win!")
test.assert_equals(diagonal([ [1, 2, 2, 5, 1, 1, 2, 2, 5, 15],
                            [4, 1, 6, 1, 1, 1, 2, 2, 1, 1],
                            [1, 8, 1, 6 ,2, 1, 2, 1, 5, 1],
                            [1, 5, 2, 1, 2, 1, 1, 2, 5, 1],
                            [1, 8, 2, 6, 1, 1, 2, 2, 5, 1],
                            [1, 2, 2, 5, 1, 1, 2, 2, 5, 1],
                            [1, 2, 2, 1, 1, 1, 1, 2, 5, 1],
                            [1, 2, 1, 5, 1, 1, 2, 1, 5, 1],
                            [1, 1, 2, 5, 1, 1, 2, 2, 1, 1],
                            [1, 2, 2, 5, 1, 1, 2, 2, 5, 15] ]), "Draw!")
test.assert_equals(diagonal([ [1, 2, 2, 5, 1],
                            [4, 1, 6, 1, 1],
                            [1, 8, 5, 6 ,2],
                            [1, 5, 2, 1, 2],
                            [1, 8, 2, 6, 1] ]), "Secondary Diagonal win!")
test.assert_equals(diagonal([ [1, 2, 2, 5, 1, 1, 2, 2, 5, 1],
                            [4, 1, 6, 1, 1, 1, 2, 2, 1, 1],
                            [1, 8, 1, 6 ,2, 1, 2, 1, 5, 1],
                            [1, 5, 2, 1, 2, 1, 1, 2, 5, 1],
                            [1, 8, 2, 6, 1, 1, 2, 2, 5, 1],
                            [1, 2, 2, 5, 1, 1, 2, 2, 5, 1],
                            [1, 2, 2, 1, 1, 1, 1, 2, 5, 1],
                            [1, 2, 1, 5, 1, 1, 2, 1, 5, 1],
                            [1, 1, 2, 5, 1, 1, 2, 2, 1, 1],
                            [1, 2, 2, 5, 1, 1, 2, 2, 5, 1] ]), "Draw!")