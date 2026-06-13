import unittest

from root_number import find_root


class RootNumberTests(unittest.TestCase):
    def test_square_root(self) -> None:
        self.assertAlmostEqual(find_root(16, 2), 4.0)

    def test_cube_root(self) -> None:
        self.assertAlmostEqual(find_root(27, 3), 3.0)

    def test_default_is_square_root(self) -> None:
        self.assertAlmostEqual(find_root(25), 5.0)

    def test_fractional_result(self) -> None:
        self.assertAlmostEqual(find_root(2, 2), 1.414213562, places=5)

    def test_negative_odd_root(self) -> None:
        self.assertAlmostEqual(find_root(-8, 3), -2.0)

    def test_negative_even_root_raises(self) -> None:
        with self.assertRaises(ValueError):
            find_root(-16, 2)

    def test_zero_root(self) -> None:
        self.assertEqual(find_root(0), 0.0)


if __name__ == "__main__":
    unittest.main()
