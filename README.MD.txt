notebook program
E library entry - genre - title - author - ebook or real?
Make Voltorb flip again?
Cat simulator
recipe book
scripture reading companion
tap tap game?
choose your own adventure game


      var names = from n in _context.Order
                  select n;
      if (!string.IsNullOrEmpty(SearchString))
      {
        orders = orders.Where(s => s.Name.Contains(SearchString));
      }