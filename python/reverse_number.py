import sys


def reverse_number(value: int) -> int:
    sign = -1 if value < 0 else 1
    reversed_digits = str(abs(value))[::-1]
    return sign * int(reversed_digits)


def main() -> None:
    user_input = sys.argv[1] if len(sys.argv) > 1 else input("Enter a number: ").strip()
    number = int(user_input)
    print("Reversed number:", reverse_number(number))


if __name__ == "__main__":
    main()