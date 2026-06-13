FROM python:3.12-slim

ENV PYTHONDONTWRITEBYTECODE=1 \
    PYTHONUNBUFFERED=1

WORKDIR /app

COPY reverse_number.py test_reverse_number.py ./

ENTRYPOINT ["python3", "reverse_number.py"]