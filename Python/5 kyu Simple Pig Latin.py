import codewars_test as test

def pig_it(text):
    return ' '.join([word[1:] + word[0] + 'ay' if word not in '!?' else word for word in text.split(' ')])

test.assert_equals(pig_it('Pig latin is cool'),'igPay atinlay siay oolcay')
test.assert_equals(pig_it('This is my string'),'hisTay siay ymay tringsay')
test.assert_equals(pig_it('O tempora o mores !'),'Oay emporatay oay oresmay !')