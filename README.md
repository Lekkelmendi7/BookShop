
Bookshop App

This Bookshop App is a full-featured e-commerce web application designed for online book sales. Developed with .NET MVC and Razor Pages, it delivers a comprehensive online shopping experience. Users can browse books, make secure online payments, and track their orders, while administrators manage inventory, order fulfillment, and user roles. This application offers robust features for both customers and admin roles, ensuring an efficient and user-friendly shopping environment.

Features:

1. Product Listing

Detailed Book Display: Each book listing shows essential details such as title, author, ISBN, price, and discount (if available).
Filtering Options: Users can filter books by categories (e.g., genre or author), price range, or other available attributes. This makes it easy for customers to find exactly what they’re looking for.

2. Online Payment Integration

Stripe Integration: Stripe is fully integrated to handle secure online payments, allowing users to pay with major credit cards and other Stripe-supported methods.
Secure and Reliable Transactions: Stripe’s built-in fraud protection ensures safe and smooth payment processes.

3. Authentication and User Management

User Registration and Login: Standard registration with options for password recovery and social login via Facebook.
Password and Email Update: Users can change their password or update their email address in account settings for added convenience.
Role-Based Access Control: There are four user roles, each with specific privileges:
Customer: Can browse the catalog, add items to the shopping cart, place orders, view order history, and manage their account.
Employee: Has access to manage inventory, view and update order statuses, and handle customer support.
Company: Partner companies can add and manage their own books in the catalog, allowing streamlined operations for partner book providers.
Admin: Holds complete control over the system, with permissions to manage books, categories, companies, and user roles. The Admin also oversees the CMS and has the authority to assign or update user roles.

4. Order Management

Order Status Tracking: Each order goes through several statuses, allowing users and administrators to track its progress:
In Process: The order has been received and is being prepared.
Payment Pending: Payment has not yet been completed.
Completed: The order has been fulfilled and shipped to the customer.
Approved: The order is reviewed and confirmed for processing.
Efficient Status Management: Employees can update order statuses in real-time, ensuring customers receive the latest information on their orders.

5. Dynamic Pricing (Quantity-Based Discount)

Bulk Discounts: This feature offers quantity-based pricing for certain books:
1-50 copies: The standard list price is applied.
51-100 copies: A discounted rate is applied.
100+ copies: Maximum discount is provided.
Automated Discount Calculation: The system dynamically applies these discounts based on the quantity selected, providing customers with real-time updates to their total.

6. Content Management System (CMS)

Full CRUD Operations: The Admin can perform Create, Read, Update, and Delete operations for:
Books: Manage the product catalog, including titles, authors, pricing, and descriptions.
Categories: Organize books into categories, making it easier for customers to browse by genre or other attributes.
Companies: Manage partner companies and their respective inventory.
Organized Shop Management: The CMS streamlines the management of content, allowing the Admin to update product details, manage inventory, and keep the shop well-organized.

7. Shopping Cart

Cart Management: Users can add items to their cart, adjust quantities, and remove items as needed.
Dynamic Total Calculation: The cart automatically updates the total price, factoring in any applicable quantity-based discounts.

8. Shipping Details

User Shipping Input: During checkout, users can enter and manage their shipping information for a smooth purchasing experience.
Admin Management: Admins oversee shipping details to ensure orders are dispatched accurately and promptly.

9. Order and Inventory Management
   
Real-Time Order Tracking: Employees and Admins can track order statuses in real-time, ensuring transparency throughout the purchasing process.
Inventory Updates: As items are sold, the system updates inventory automatically, preventing stock shortages and enabling accurate order processing.


Stack and Technologies Used:

Back-End: Built with .NET Core, utilizing MVC (Model-View-Controller) architecture for a well-organized and maintainable codebase.
Front-End: Designed with HTML, CSS, and Razor Pages, creating a responsive and user-friendly interface.
Authentication and Security: JWT (JSON Web Token) and .NET Identity provide secure authentication, role-based access, and account management.
Payment Processing: Integrated with Stripe for secure and reliable payment handling.
Database: MSSQL is used to manage data persistence and supporting complex queries and transactions.



Photos of the project:

![Register - Bookshop](https://github.com/user-attachments/assets/7532b938-bbfd-4bbf-8dc3-278c4e192e27)
![Faqja kryesore e bookshop](https://github.com/user-attachments/assets/6d8c4c1e-b02d-43a2-b44b-75d716684fa3)
![Screenshot 2024-11-13 223827](https://github.com/user-attachments/assets/2007055b-f4b2-4e34-bd88-9517d0c8efbc)
![Screenshot 2024-11-13 223813](https://github.com/user-attachments/assets/0af3cfac-91a4-4e9a-8ec2-ff873cb05631)
![Screenshot 2024-11-13 223735](https://github.com/user-attachments/assets/ca48e8c9-4655-4447-a6d4-87a8977c7db8)
![Screenshot 2024-11-13 223721](https://github.com/user-attachments/assets/ac776303-c6e6-4e5f-b04f-d1f269d1f476)
![Screenshot 2024-11-13 223656](https://github.com/user-attachments/assets/0c07deb5-b30a-4295-aced-c801f0dd4a30)
![Screenshot 2024-11-13 223449](https://github.com/user-attachments/assets/54c69f1f-4bbe-4089-843c-985284bdf985)
![Screenshot 2024-11-13 223353](https://github.com/user-attachments/assets/63f8630c-46b3-4db5-a3ca-48ccd51c1f00)
![Screenshot 2024-11-13 223326](https://github.com/user-attachments/assets/0c0e2010-6a4d-4681-9fcc-5f9352e45f33)
![Screenshot 2024-11-13 223308](https://github.com/user-attachments/assets/8d65388a-b70b-453d-aec7-a11142349029)
![Screenshot 2024-11-13 223256](https://github.com/user-attachments/assets/298cf01c-eb45-4ee3-9ef8-62118d22c2b9)
![Screenshot 2024-11-13 223211](https://github.com/user-attachments/assets/ce542dc5-0453-4bf5-b2fc-ce91a50b0daa)
![Screenshot 2024-11-13 223201](https://github.com/user-attachments/assets/d0915805-7075-49dd-9a93-6b8312236c36)
![Screenshot 2024-11-13 223148](https://github.com/user-attachments/assets/d996caad-c080-4dd0-a214-84f4bdcda54c)
![Screenshot 2024-11-13 223035](https://github.com/user-attachments/assets/3421f5d8-3541-4c89-a5fd-992823b189cc)
![Screenshot 2024-11-13 223014](https://github.com/user-attachments/assets/fad00c30-0313-4af5-862c-60069906b230)
![Screenshot 2024-11-13 222959](https://github.com/user-attachments/assets/6d157a46-7f9a-46f1-813f-6e8d4301710d)
![Screenshot 2024-11-13 222929](https://github.com/user-attachments/assets/afe002c7-23c5-42d3-a1e4-31a3771b2863)
![Screenshot 2024-11-13 222726](https://github.com/user-attachments/assets/cf14fa2b-cfc0-4577-b2d0-9036cbe60c60)
![Screenshot 2024-11-13 222325](https://github.com/user-attachments/assets/889d2427-ac19-4be9-b5ef-fa4d8d75c06e)
![Screenshot 2024-11-13 222230](https://github.com/user-attachments/assets/7c821006-2d2e-46b2-bda8-8c68ef2ce4c7)
![Screenshot 2024-11-13 225139](https://github.com/user-attachments/assets/9ace8598-c6e6-4727-b03d-980905250be4)
![Screenshot 2024-11-13 225123](https://github.com/user-attachments/assets/56a15f16-08da-4fdf-b386-b7998e28b57d)
![Screenshot 2024-11-13 225114](https://github.com/user-attachments/assets/a807cc92-427b-49ce-b2ed-a4ce245a9735)
![Screenshot 2024-11-13 223836](https://github.com/user-attachments/assets/5bb9d496-dab8-4bee-b042-53070a20cfdd)






