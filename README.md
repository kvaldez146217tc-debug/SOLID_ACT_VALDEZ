## Refactoring Notes — SOLID Principles

The original Form1.cs handled everything: calculations, discounts, database access, email, and UI. The code was refactored to follow the SOLID principles.

## SOLID Principles Applied
## 1. Single Responsibility Principle (SRP)**

Each class now has one main responsibility:

OrderCalculator — calculates totals and discounts

SqlOrderRepository — handles database operations

SmtpInvoiceSender — sends invoices by email

MessageBoxInvoicePrinter — displays invoices

Form1 — handles the UI

This makes the code easier to maintain and change.

## 2. Open/Closed Principle (OCP)

Discounts are separated into individual IDiscountStrategy classes.

To add a new discount, such as a Holiday Discount, create a new strategy class without changing the existing discount logic.

## 3. Liskov Substitution Principle (LSP)

All discount strategies follow the same IDiscountStrategy contract.

OrderCalculator can use any discount strategy without needing to know its specific implementation.

## 4. Interface Segregation Principle (ISP)

Instead of one large IOrderService, the project uses smaller interfaces:

IOrderRepository

IInvoiceSender

IInvoicePrinter

IOrderCalculator

Each class only depends on the functionality it needs.

## 5. Dependency Inversion Principle (DIP)

Form1 no longer creates SqlConnection or SmtpClient directly.

Instead, it depends on interfaces. The actual implementations are created in Program.cs and passed to Form1 through Configure().

This makes it easier to replace the database or email provider later.

## Designer Support

Form1 still has a parameterless constructor so the Windows Forms Designer can open it.

The actual dependencies are provided through Configure() when the application starts.
