DB Lock: Lock is a method used to ensure the sequentiality of transaction processing. If you are paying for a product with your checking account and you only have one dollar left, at the same time your $1 music subscription payment is processed in your account due to the absence of proper DB locking, resulting in a balance of -$1 in your account.
A transaction is the smallest unit of processing in a database that cannot be divided.

Types of Locks:

Shared Lock:
A shared lock is used when reading data. Multiple shared locks can be accessed simultaneously. In other words, multiple users can read the same data at the same time using shared locks. However, shared locks cannot be used with exclusive locks on the same data.

Exclusive Lock:
An exclusive lock is used when modifying data, and it is maintained until the transaction is completed. While an exclusive lock is held, no other transaction (including reads) can access the resource. Additionally, other transactions cannot acquire locks on data that is being modified.

Blocking:
Blocking refers to a state where a specific session is unable to proceed with its operations due to competition between locks (also known as a race condition). Blocking can occur between shared locks and exclusive locks or between exclusive locks themselves. The only way to resolve blocking is through transaction commit or rollback.

Deadlock:
A deadlock refers to a state of mutual deadlock between transactions. It occurs when each transaction tries to acquire a lock on a resource that the other transaction is holding. Deadlocks can lead to a situation where none of the transactions can progress.