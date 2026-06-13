# Reverse Number Program

This project contains a small Python program that reverses the digits of an integer.

## Quick start

### Prerequisites

- Python 3.12+ or Docker
- Docker Compose if you want to use the container workflow

### Run locally

Run the script and enter a number when prompted:

```bash
python3 reverse_number.py
```

Example:

```text
Enter a number: 12340
Reversed number: 4321
```

You can also pass the number as a command-line argument:

```bash
python3 reverse_number.py 4561
```

## Run tests

Run all tests:

```bash
python3 -m unittest discover
```

Run only this test file:

```bash
python3 -m unittest test_reverse_number.py
```

## Run with Docker

Build the image:

```bash
docker build -t reverse-number-app .
```

Run the container with a number:

```bash
docker run --rm reverse-number-app 4561
```

Example output:

```text
Reversed number: 1654
```

## Run with Docker Compose

Run the app service:

```bash
docker compose run --build --rm app
```

By default, the `app` service passes `4561` from `compose.yaml`, so the output is `1654` unless you override it.

Run the app service with a different number:

```bash
docker compose run --build --rm app 1234
```

Run the test service:

```bash
docker compose run --build --rm test
```

## Project files

- `reverse_number.py` - application code
- `test_reverse_number.py` - unit tests
- `root_number.py` - find nth root of a number
- `test_root_number.py` - unit tests for root finding
- `Dockerfile` - container image definition
- `compose.yaml` - Docker Compose services for the app and tests

## Root finder

Find the nth root of a number using `root_number.py`.

### Local usage

Find the square root (default):

```bash
python3 root_number.py 25
```

Output:

```text
Root (degree 2) of 25.0: 5.0
```

Find the cube root:

```bash
python3 root_number.py 27 3
```

Output:

```text
Root (degree 3) of 27.0: 3.0
```

### Test root finding

```bash
python3 -m unittest test_root_number.py
```

The tests cover square roots, cube roots, fractional results, and error handling for negative even roots.
