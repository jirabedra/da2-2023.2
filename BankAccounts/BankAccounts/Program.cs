using BankAccounts;

internal class Main
{
    static void Run()
    {
        BankAccount sharedBankAccount = new BankAccount() { Balance = 1000 };
        Friend me = new Friend() { Account = sharedBankAccount };
    }

    void MakeNewFriend()
    {
        //Cant access sharedBankAccount. Must pass it as an argument to a method
        //or define some kind of singleton or static definition
        //or store it in some kind of context made by myself
        Friend someFriend = new Friend() { Account =  }
    }
}

