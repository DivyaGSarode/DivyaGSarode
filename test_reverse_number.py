import unittest

from reverse_number import reverse_number


class ReverseNumberTests(unittest.TestCase):
    def test_reverses_positive_number(self) -> None:
        self.assertEqual(reverse_number(12345), 54321)

    def test_drops_leading_zeroes_in_result(self) -> None:
        self.assertEqual(reverse_number(1200), 21)

    def test_reverses_negative_number(self) -> None:
        self.assertEqual(reverse_number(-987), -789)

    def test_zero_stays_zero(self) -> None:
        self.assertEqual(reverse_number(0), 0)


if __name__ == "__main__":
    unittest.main()