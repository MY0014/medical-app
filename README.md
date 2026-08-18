# Medical Appointments

Full-stack medical appointment booking application built with React, Vite, C#, ASP.NET Core and PostgreSQL.

The application allows patients to search for doctors, check availability, book medical appointments and simulate consultation payments.

---

## Project Overview

Medical Appointments is a web application designed to simulate a real-world medical appointment platform.

The project includes:

- User registration and authentication
- JWT-based authentication
- Doctor management
- Medical specialties
- Doctor availability
- Appointment booking
- Appointment management
- Simulated consultation payments
- Payment status management
- Patient dashboard
- Responsive React interface

---

## Architecture

The project uses a full-stack architecture:

```text
┌─────────────────────────────┐
│         React + Vite        │
│          Frontend           │
└──────────────┬──────────────┘
               │
               │ REST API / JSON
               ▼
┌─────────────────────────────┐
│       ASP.NET Core API      │
│           Backend           │
└──────────────┬──────────────┘
               │
               │ Entity Framework Core
               ▼
┌─────────────────────────────┐
│          PostgreSQL         │
│           Database          │
└─────────────────────────────┘
