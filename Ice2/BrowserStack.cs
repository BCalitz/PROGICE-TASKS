class BrowserStack
{
    private List<string> history = new List<string>();


    public void Navigate(string address)
    {
        if (address != "q")
        {
            history.Add(address);
        }
    }

    public string Back()
    {
        if (history.Count > 0)
        {
            history.RemoveAt(history.Count - 1);
            return history[history.Count - 1];
        }
        else
        {
            return "Nothing to go back to.";
        }
    }

    public string CurrentUrl
    {
        get
        {
            if (history.Count == 0) return "No URL";
            return history[history.Count - 1];
        }
    }

    public bool isEmpty()
    {
        return history.Count == 0;
    }

    public int Count
    {
        get
        {
            return history.Count;
        }
    }


}