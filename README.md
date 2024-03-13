# final-project
1.ความเป็นมาของโปรแกรม

ผมเห็นการต่อแถวซื้อบัตรเข้าไปดูพวกคอน หรือ หนังการแปลง
ผมเห็นว่าบางที่ยังไม่มีการนำเทคโนโลยีมาใช้
ผมจึงอยากนำสิ่งที่ผมได้เรียนมาใช้ครับ



2.วัตถุประสงค์ของโปรแกรม
ทำระบบการจองบัตรคอนแบบต่อแถวซื้อทีละคน


3.โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown
```mermaid
classDiagram
    Ticket <|-- customer
    Ticket <|-- Control
    Form1 -- TicketType
    Form1 -- Control
    Form1 -- customer
    Form1 -- Ticket


   class Form1{
    
        Control control
        List<customer> customerList 
        Ticket ticket  
        +Show_all()
        +clear_all()
        button1_Click()
        TK_Click()
        TM_Click()
        save_Click()
        button1_Click_1()
        change()
    }


class Form1 {
        -Control Control
        -List<customer> customerList
        -Ticket ticket
        +Form1()
        +Show_all(): void
        +clear_all(): void
        +button1_Click(sender: object, e: EventArgs): void
        +TK_Click(sender: object, e: EventArgs): void
        +TM_Click(sender: object, e: EventArgs): void
        +Form1_Load(sender: object, e: EventArgs): void
        +save_Click(sender: object, e: EventArgs): void
        +button1_Click_1(sender: object, e: EventArgs): void
    }



   class TicketType {
        +Standing_viewing: int
        +View_tickets: int
        +VIP_Ticket: int
    }


   class Ticket {
        -DateTime tm
        +DateTime time_stamp()
        +Ticket(time_stamp: DateTime)
        +Ticket()
        +bool WriteF(customers: List<customer>): bool
    }

  

    
   class Control{
        +ticket
        +buyticket()
        +buyticketnr()
        +buyticketst()
    
    }



  class customer{
      
      +customer(gender: string, price: int, now: DateTime)
      -string gender
      -int price
   }



   
```
4.ชื่อของผู้พัฒนาโปรแกรม
นาย นวพรหม ภูผาผิว 663450040-2
 
