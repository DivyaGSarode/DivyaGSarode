import sys


def find_root(value: float, root_degree: int = 2) -> float:
    """
    Find the nth root of a number.
    
    Args:
        value: The number to find the root of
        root_degree: The degree of the root (default 2 for square root)
    
    Returns:
        The nth root of the value
    
    Raises:
        ValueError: If value is negative and root_degree is even
    """
    if value < 0 and root_degree % 2 == 0:
        raise ValueError("Cannot compute even root of negative number")
    
    if value < 0:
        return -((-value) ** (1 / root_degree))
    
    return value ** (1 / root_degree)


def main() -> None:
    if len(sys.argv) < 2:
        print("Usage: python3 root_number.py <number> [root_degree]")
        print("Example: python3 root_number.py 16 2")
        print("Example: python3 root_number.py 27 3")
        sys.exit(1)
    
    try:
        value = float(sys.argv[1])
        root_degree = int(sys.argv[2]) if len(sys.argv) > 2 else 2
        
        if root_degree == 0:
            raise ValueError("Root degree cannot be 0")
        
        result = find_root(value, root_degree)
        print(f"Root (degree {root_degree}) of {value}: {result}")
    except ValueError as e:
        print(f"Error: {e}")
        sys.exit(1)
    except IndexError:
        print("Error: Invalid arguments")
        sys.exit(1)


if __name__ == "__main__":
    main()
