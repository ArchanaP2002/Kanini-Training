using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Movie.Model
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public DateTime Date { get; set; }

    }
}
/* id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(50) NOT NULL,
  email VARCHAR(50) UNIQUE NOT NULL,
  password VARCHAR(255) NOT NULL,
  phone VARCHAR(15),
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP


---------------------------------------
-- Create a table for customers
CREATE TABLE customers (
  id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(50) NOT NULL,
  email VARCHAR(50) UNIQUE NOT NULL,
  password VARCHAR(255) NOT NULL,
  phone VARCHAR(15),
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Create a table for movies
CREATE TABLE movies (
  id INT PRIMARY KEY AUTO_INCREMENT,
  title VARCHAR(100) NOT NULL,
  release_date DATE NOT NULL,
  duration_min INT NOT NULL,
  genre VARCHAR(50),
  rating VARCHAR(10)
);

-- Create a table for auditoriums
CREATE TABLE auditoriums (
  id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(50) NOT NULL,
  seats_no INT NOT NULL
);

-- Create a table for screenings
CREATE TABLE screenings (
  id INT PRIMARY KEY AUTO_INCREMENT,
  movie_id INT NOT NULL,
  auditorium_id INT NOT NULL,
  screening_start DATETIME NOT NULL,
  price DECIMAL(10,2) NOT NULL,
  FOREIGN KEY (movie_id) REFERENCES movies(id),
  FOREIGN KEY (auditorium_id) REFERENCES auditoriums(id),
  UNIQUE (auditorium_id, screening_start)
);

-- Create a table for seats
CREATE TABLE seats (
  id INT PRIMARY KEY AUTO_INCREMENT,
  auditorium_id INT NOT NULL,
  row_no INT NOT NULL,
  seat_no INT NOT NULL,
  FOREIGN KEY (auditorium_id) REFERENCES auditoriums(id),
  UNIQUE (auditorium_id, row_no, seat_no)
);

-- Create a table for tickets
CREATE TABLE tickets (
  id INT PRIMARY KEY AUTO_INCREMENT,
  customer_id INT NOT NULL,
  screening_id INT NOT NULL,
  seat_id INT NOT NULL,
  booked_at DATETIME DEFAULT CURRENT_TIMESTAMP,
  status ENUM('booked', 'cancelled') DEFAULT 'booked',
  FOREIGN KEY (customer_id) REFERENCES customers(id),
  FOREIGN KEY (screening_id) REFERENCES screenings(id),
  FOREIGN KEY (seat_id) REFERENCES seats(id),
  UNIQUE (screening_id, seat_id)
);

-- Create a table for managers
CREATE TABLE managers (
  id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(50) NOT NULL,
  email VARCHAR(50) UNIQUE NOT NULL,
  password VARCHAR(255) NOT NULL,
  phone VARCHAR(15),
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);
*/
