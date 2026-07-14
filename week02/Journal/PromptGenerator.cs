using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        ReloadPrompts();
    }

    public void ReloadPrompts()
    {
        _prompts.Clear();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GetRandomPrompt()
    {
        if ( _prompts.Count == 0 )
        {
            ReloadPrompts();
        }

        Random random_index = new Random();
        int prompt_index = random_index.Next(_prompts.Count);

        string random_prompt = _prompts[prompt_index];

        _prompts.RemoveAt(prompt_index);

        return random_prompt;
    }
}