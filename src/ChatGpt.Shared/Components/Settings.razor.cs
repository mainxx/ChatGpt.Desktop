﻿using Masa.Blazor.Presets;

namespace ChatGpt.Shared;

public partial class Settings
{
    [Parameter]
    public bool Value { get; set; }

    [Parameter]
    public EventCallback<bool> ValueChanged { get; set; }

    [Parameter]
    public ChatGptOptions ChatGptOptions { get; set; }

    [Parameter]
    public EventCallback<ChatGptOptions> ChatGptOptionsChanged { get; set; }

    [Parameter]
    public EventCallback<ModalActionEventArgs> OnSave { get; set; }

    [Parameter]
    public EventCallback<ModalActionEventArgs> OnCancel { get; set; }

    public ShortcutKey GetShortcutKey(string name)
    {
        return (ShortcutKey)Enum.Parse(typeof(ShortcutKey), name);
    }

    private List<string> _items = new()
    {
        nameof(ShortcutKey.CtrlEnter), nameof(ShortcutKey.Enter), nameof(ShortcutKey.Shift),nameof(ShortcutKey.ShiftEnter),
    };
}
