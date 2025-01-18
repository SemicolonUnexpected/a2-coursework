input = 'Dashboard, Calendar, Upcoming bookings, Recent bookings, View locations, View customers, Recent customers, Stock usage, Manage stock, Pending orders, Current stock, Overview, Cleaning, Cleaning stock, View staff, Change password, Business closure, Passwords, Login attempts, Appearance, Account statistics, Personal information'


def main():
    btnNames = input.split(', ')
    
    print('Generating code:\n')
    for name in btnNames:
         print(f'    public event EventHandler? {name.title().replace(' ', '')}Toggled;')

    print()
    print('    private void InvokeToggledEvent(string name) {')
    print(f'        if (name == "{btnNames[0]}") {btnNames[0].title().replace(' ', '')}Toggled?.Invoke(this, EventArgs.Empty);')
    for name in btnNames[1:]:
        print(f'        else if (name == "{name}") {name.title().replace(' ', '')}Toggled?.Invoke(this, EventArgs.Empty);')
    print()
    print('        else throw new NotImplementedException();')
    print('    }')


if __name__ == '__main__':
    main()
