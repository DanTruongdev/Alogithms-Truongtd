namespace Algorithm.Objects
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ParentId { get; set; }

        public Menu(int id, string title, int parentId)
        {
            Id = id;
            Title = title;
            ParentId = parentId;
        }

        /**
         * Prints the hierarchical menu structure recursively starting from the root level.
         * @param menus The list of Menu objects representing the entire menu structure.
         */
        public static void PrintMenu(List<Menu> menus)
        {
            PrintSubMenu(menus, 0, 0);
        }

        /**
         * Helper method to print submenus recursively.
         * @param menus The list of Menu objects representing the entire menu structure.
         * @param parentId The identifier of the parent menu to print its submenus.
         * @param level The current level of indentation in the menu hierarchy.
         */
        private static void PrintSubMenu(List<Menu> menus, int parentId, int level)
        {
            var subMenus = menus.Where(m => m.ParentId == parentId).ToList();
            foreach (var menu in subMenus)
            {
                Console.WriteLine(new string('-', level * 2) + menu.Title);
                PrintSubMenu(menus, menu.Id, level + 1);
            }
        }
    }
}
