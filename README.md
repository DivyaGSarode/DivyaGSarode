# Multi-Language Programming Projects

This workspace contains Python and C# applications with comprehensive tests and Docker support, organized in separate directories for independent building and testing.

## Project Structure

```
DivyaGSarode/
├── python/
│   ├── reverse_number.py       - reverses digits of integers
│   ├── root_number.py          - computes nth roots
│   ├── test_reverse_number.py  - unit tests for reverse_number
│   ├── test_root_number.py     - unit tests for root_number
│   ├── Dockerfile.python       - Python container image
│   └── .dockerignore
├── csharp/
│   ├── Program.cs              - GCD (Greatest Common Divisor) finder
│   ├── GCDFinder.csproj        - C# project file (.NET 10)
│   └── Dockerfile.csharp       - C# container image
├── compose.yaml                - multi-service Docker Compose configuration
└── README.md                   - this file
```

## Python Projects

### Run Locally

Navigate to the python directory:

```bash
cd python
```

Run the reverse number program:

```bash
python3 reverse_number.py 12340
```

Output:
```text
Reversed number: 4321
```

Run the root finder:

```bash
python3 root_number.py 27 3
```

Output:
```text
Root (degree 3) of 27.0: 3.0
```

### Run Python Tests

From the python directory:

```bash
python3 -m unittest discover -v
```

**Expected output:** 11 tests pass (4 reverse number tests + 7 root number tests)

### Build and Run with Docker

Build the Python image:

```bash
docker build -f python/Dockerfile.python -t reverse-number-app ./python
```

Run the Python app:

```bash
docker run --rm reverse-number-app 4561
```

## C# Projects

### Run Locally

Navigate to the csharp directory:

```bash
cd csharp
```

Run the GCD finder:

```bash
dotnet run 48 18
```

Output:
```text
GCD of 48 and 18: 6
```

### Build Locally

```bash
dotnet build GCDFinder.csproj
```

### Build and Run with Docker

Build the C# image:

```bash
docker build -f csharp/Dockerfile.csharp -t gcd-finder-app ./csharp
```

Run the C# app:

```bash
docker run --rm gcd-finder-app 48 18
```

## Run with Docker Compose

From the root directory, use Docker Compose to orchestrate both services:

Run the Python app (default: reverse 4561 → 1654):

```bash
docker compose run --build python-app
```

Override Python app with a custom number:

```bash
docker compose run --build python-app 1234
```

Run Python tests:

```bash
docker compose run --build python-test
```

Run the C# GCD finder (default: GCD of 48 and 18 → 6):

```bash
docker compose run --build csharp-app
```

Override C# app with custom numbers:

```bash
docker compose run --build csharp-app 100 50
```

## Project Details

### Python: Reverse Number
- **Function:** Reverses the digits of an integer
- **Features:** 
  - Handles negative numbers (preserves sign)
  - Strips leading zeros in result
  - Command-line argument support
- **Tests:** 4 unit tests covering positive/negative/zero/trailing zeros
- **Example:** `python3 reverse_number.py 12340` → `Reversed number: 4321`

### Python: Root Number
- **Function:** Computes the nth root of a number
- **Features:**
  - Default square root (degree 2)
  - Supports any root degree
  - Error handling for negative even roots
  - Supports fractional results
- **Tests:** 7 unit tests covering square/cube/fractional/negative/zero
- **Example:** `python3 root_number.py 27 3` → `Root (degree 3) of 27.0: 3.0`

### C#: GCD Finder
- **Function:** Finds the Greatest Common Divisor of two numbers
- **Algorithm:** Euclidean algorithm
- **Features:**
  - Handles negative inputs (uses absolute values)
  - Efficient computation
  - Command-line argument support
- **Framework:** .NET 10.0
- **Example:** `dotnet run 48 18` → `GCD of 48 and 18: 6`

## Prerequisites

- **Python projects:** Python 3.12+
- **C# projects:** .NET 10.0 SDK
- **Docker support:** Docker and Docker Compose

## Commands Quick Reference

| Task | Command |
|------|---------|
| Run Python reverse | `cd python && python3 reverse_number.py 12340` |
| Run Python root | `cd python && python3 root_number.py 27 3` |
| Test Python | `cd python && python3 -m unittest discover` |
| Run C# GCD | `cd csharp && dotnet run 48 18` |
| Build C# | `cd csharp && dotnet build` |
| Python Docker | `docker build -f python/Dockerfile.python -t reverse-number-app ./python && docker run --rm reverse-number-app 4561` |
| C# Docker | `docker build -f csharp/Dockerfile.csharp -t gcd-finder-app ./csharp && docker run --rm gcd-finder-app 48 18` |
| Compose Python App | `docker compose run --build python-app` |
| Compose Python Tests | `docker compose run --build python-test` |
| Compose C# App | `docker compose run --build csharp-app` |
