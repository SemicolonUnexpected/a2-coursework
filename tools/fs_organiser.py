import os

def explore_folder_structure(folder_path, output_file, indent=""):
    try:
        for item in os.listdir(folder_path):
            item_path = os.path.join(folder_path, item)
            output_file.write(indent + item + "\n")
            if os.path.isdir(item_path):
                explore_folder_structure(item_path, output_file, indent + "  ")
    except FileNotFoundError:
        output_file.write(f"Error: Folder '{folder_path}' not found.\n")
    except Exception as e:
        output_file.write(f"An error occurred: {e}\n")

if __name__ == "__main__":
    folder_to_explore = input("Enter the folder path to explore: ")
    output_filename = input("Enter the output filename (e.g., structure.txt): ")

    try:
        with open(output_filename, "w") as output_file:  # Open in write mode ("w")
            explore_folder_structure(folder_to_explore, output_file)
        print(f"Folder structure written to {output_filename}")
    except Exception as e:
        print(f"An error occurred while writing to file: {e}")
