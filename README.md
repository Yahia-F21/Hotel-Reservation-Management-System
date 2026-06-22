# Hotel Reservation Management System

A Windows Forms application built with C# and SQL Server for managing hotel reservations, guests, and rooms.

## Overview

This is a comprehensive Hotel Reservation Database Management System that enables hotel staff to:
- Manage guest information
- Manage room inventory
- Create and manage reservations
- Process guest check-ins and check-outs
- Update reservation dates and payment information

## Features

### 1. Guest Management
- Add, view, update, and delete guest information
- Maintain guest contact details and personal information

### 2. Room Management
- Manage room inventory with room types and rates
- Track room status and availability
- Maintain room details and amenities information

### 3. Reservation Management
- Create new reservations for guests
- Update existing reservations
- Modify check-in and check-out dates
- Automatic conflict detection to prevent double-booking

### 4. Checkout Processing
- Process guest checkouts
- Record payment methods
- Generate checkout transactions

## Technology Stack

- **Framework**: .NET Framework 4.7.2
- **Language**: C#
- **UI**: Windows Forms
- **Database**: SQL Server
- **IDE**: Visual Studio 2022+

## Project Structure

```
DBProj/
├── MainScene.cs                    # Main application entry form
├── GuestForm.cs                    # Guest management interface
├── RoomForm.cs                     # Room management interface
├── ResMenuForm.cs                  # Reservation menu interface
├── CreateResForm.cs                # Create reservation form
├── UpdateCheckoutForm.cs           # Update reservation and process checkout
├── DBHelper.cs                     # Database helper utilities
├── Program.cs                      # Application entry point
├── Properties/                     # Project properties
├── obj/                           # Build output
└── DBProj.csproj                  # Project file
```

## Prerequisites

Before running this application, ensure you have:

- **Windows OS** (7 or later)
- **.NET Framework 4.7.2** or higher
- **SQL Server** (2012 or later)
- **Visual Studio 2019+** (for development)

## Setup Instructions

### 1. Database Setup

1. Open SQL Server Management Studio
2. Create a new database named `HotelReservationDB`
3. Execute the following SQL scripts to create the required tables:

```sql
-- Create Guest table
CREATE TABLE Guest (
    GuestID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100),
    Phone NVARCHAR(20),
    Address NVARCHAR(150)
);

-- Create Room table
CREATE TABLE Room (
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomNumber NVARCHAR(10) UNIQUE NOT NULL,
    RoomType NVARCHAR(50) NOT NULL,
    PricePerNight DECIMAL(10, 2) NOT NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Available'
);

-- Create Reservation table
CREATE TABLE Reservation (
    ResID INT PRIMARY KEY IDENTITY(1,1),
    GuestID INT NOT NULL,
    RoomID INT NOT NULL,
    CheckIn DATETIME NOT NULL,
    CheckOut DATETIME NOT NULL,
    TotalPrice DECIMAL(10, 2),
    Status NVARCHAR(20) NOT NULL DEFAULT 'Active',
    FOREIGN KEY (GuestID) REFERENCES Guest(GuestID),
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID)
);

-- Create Checkout table
CREATE TABLE Checkout (
    CheckoutID INT PRIMARY KEY IDENTITY(1,1),
    ResID INT NOT NULL,
    CheckoutDate DATETIME NOT NULL,
    PaymentMethod NVARCHAR(50),
    Amount DECIMAL(10, 2),
    FOREIGN KEY (ResID) REFERENCES Reservation(ResID)
);
```

### 2. Stored Procedures

Create the following stored procedures:

```sql
-- Stored Procedure to update reservation date
CREATE PROCEDURE sp_UpdateReservationDate
    @ResID INT,
    @NewCheckOut DATETIME
AS
BEGIN
    UPDATE Reservation
    SET CheckOut = @NewCheckOut
    WHERE ResID = @ResID;
END;

-- Stored Procedure to process checkout
CREATE PROCEDURE sp_ProcessCheckoutByGuest
    @GuestID INT,
    @PaymentMethod NVARCHAR(50)
AS
BEGIN
    DECLARE @ResID INT, @Amount DECIMAL(10, 2);

    SELECT TOP 1 @ResID = ResID 
    FROM Reservation 
    WHERE GuestID = @GuestID AND Status = 'Active'
    ORDER BY CheckOut ASC;

    IF @ResID IS NOT NULL
    BEGIN
        SELECT @Amount = TotalPrice FROM Reservation WHERE ResID = @ResID;

        INSERT INTO Checkout (ResID, CheckoutDate, PaymentMethod, Amount)
        VALUES (@ResID, GETDATE(), @PaymentMethod, @Amount);

        UPDATE Reservation
        SET Status = 'Completed'
        WHERE ResID = @ResID;
    END;
END;
```

### 3. Application Configuration

1. Open the project in Visual Studio
2. Locate the connection string in each form file (currently hardcoded):
   - `MainScene.cs`
   - `UpdateCheckoutForm.cs`
   - Other form files
3. Update the connection string to match your SQL Server instance:
   ```csharp
   string connString = "Server=YOUR_SERVER\\SQLEXPRESS;Database=HotelReservationDB;Integrated Security=True;";
   ```

### 4. Build and Run

1. Open `DBProj.csproj` in Visual Studio
2. Build the solution: `Ctrl+Shift+B`
3. Run the application: `F5`

## Usage

### Guest Management
1. Click the **Guest** button from the main menu
2. Add new guests, view existing guests, or manage guest information

### Room Management
1. Click the **Room** button from the main menu
2. Add rooms, update room status, or manage room details

### Create Reservation
1. Click the **Reservation** button from the main menu
2. Select **Create Reservation**
3. Choose a guest and room, then set check-in and check-out dates
4. The system will automatically check for booking conflicts

### Update Reservation & Checkout
1. From the Reservation menu, select **Update Checkout**
2. Enter the Reservation ID to modify check-out dates
3. Or process a guest checkout by entering Guest ID and payment method

## Key Functions

### DBHelper Class
Provides database abstraction layer with utility methods:
- `ExecuteDataTable()` - Execute SELECT queries
- `ExecuteNonQuery()` - Execute INSERT, UPDATE, DELETE operations
- `RecordExists()` - Check if records exist in the database

### Error Handling
All database operations include comprehensive error handling:
- SQL exceptions are caught and reported
- Invalid operations are handled gracefully
- User-friendly error messages are displayed

## Important Notes

⚠️ **Security Considerations**:
- Connection strings are currently hardcoded. For production, use configuration files or environment variables
- SQL Server uses integrated security. Ensure proper user permissions are configured
- Consider implementing user authentication for the application

⚠️ **Database Conflicts**:
- The system automatically prevents double-booking by checking for overlapping reservations
- Date validations ensure check-out is after check-in

## Future Enhancements

- [ ] Move connection strings to configuration files
- [ ] Implement user authentication and role-based access
- [ ] Add reporting and analytics features
- [ ] Implement email notifications for reservations
- [ ] Add payment gateway integration
- [ ] Create admin dashboard
- [ ] Add multi-language support
- [ ] Implement data backup and recovery

## Troubleshooting

### Connection Issues
- Verify SQL Server is running: `Services > SQL Server (SQLEXPRESS)`
- Check connection string matches your server instance
- Ensure Windows Authentication is enabled in SQL Server

### Database Errors
- Verify all tables and stored procedures are created
- Check user has proper permissions on the database
- Review error messages in message boxes for specific issues

### Build Errors
- Ensure .NET Framework 4.7.2 is installed
- Clean and rebuild the solution
- Check for missing NuGet package references

## Contributing

To contribute to this project:
1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Submit a pull request

## License

This project is provided as-is for educational and commercial use.

## Author

Developed as a Hotel Reservation Management System for database and Windows Forms learning.

## Support

For issues, questions, or suggestions, please open an issue in the repository or contact the development team.

---

**Last Updated**: 2024
