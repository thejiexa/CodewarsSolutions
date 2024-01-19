import codewars_test as test
from math import pi
from math import radians

def hand_angle(hours, minutes):
	return min(360 - abs(0.5 * (hours * 60 + minutes) - (6 * minutes)), abs(0.5 * (hours * 60 + minutes) - (6 * minutes))) * pi / 180

#  def hand_angle(hours, minutes):
#     h = 0.5 * (hours * 60 + minutes)
#     m = (6 * minutes)
#     angle = abs(h - m)
#     angle = min(360 - angle, angle)
#     return angle * pi / 180


def do_test(hours, minutes, expected_deg):
    expected = radians(expected_deg)
    actual = hand_angle(hours, minutes)
    test.assert_approx_equals(actual, expected, 1e-4, message = f'for hours = {hours}, minutes = {minutes}\n')

@test.describe('tests')
def tests():
	@test.it('sample tests')
	def sample_tests():
		# hours, minutes, degrees
		do_test(0, 0, 0)
		do_test(12, 0, 0)
		do_test(6, 0, 180)
		do_test(1, 0, 30)
		do_test(9, 0, 90)
		do_test(10, 0, 60)
		do_test(0, 15, 82.5)
		do_test(0, 45, 112.5)
		do_test(12, 30, 165)
		do_test(7, 15, 127.5)
		do_test(6, 5, 152.5)