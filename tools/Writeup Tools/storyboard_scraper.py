import re
from collections import defaultdict

def extract_controls(designer_file):
    with open(designer_file, "r", encoding="utf-8") as file:
        content = file.read()

    controls = {}
    parent_map = defaultdict(list)

    # Match Location and Size separately
    location_pattern = re.compile(r"(\w+)\.Location\s*=\s*new\s*Point\((\d+),\s*(\d+)\);")
    size_pattern = re.compile(r"(\w+)\.Size\s*=\s*new Size\((\d+),\s*(\d+)\);")
    parent_pattern = re.compile(r"(\w+)\.Controls\.Add\((\w+)\);")

    for match in location_pattern.finditer(content):
        control_name, x, y = match.groups()
        controls.setdefault(control_name, {})["x"] = int(x)
        controls[control_name]["y"] = int(y)

    for match in size_pattern.finditer(content):
        control_name, width, height = match.groups()
        controls.setdefault(control_name, {})["width"] = int(width)
        controls[control_name]["height"] = int(height)

    for match in parent_pattern.finditer(content):
        parent, child = match.groups()
        controls.setdefault(child, {})["parent"] = parent
        parent_map[parent].append(child)

    return controls, parent_map

def generate_svg(controls, parent_map, output_file="form_layout.svg"):
    svg_elements = [
        '<svg xmlns="http://www.w3.org/2000/svg" width="1000" height="1000" style="background:#f0f0f0;">'
    ]

    def draw_control(control_name, offset_x=0, offset_y=0):
        control = controls.get(control_name, {})
        if "x" not in control or "width" not in control:
            return  # Skip incomplete controls

        x, y = control["x"] + offset_x, control["y"] + offset_y
        width, height = control["width"], control["height"]

        # Draw the control rectangle with a black border
        svg_elements.append(
            f'<rect x="{x}" y="{y}" width="{width}" height="{height}" fill="lightblue" stroke="black" stroke-width="1"/>'
            f'<text x="{x + 5}" y="{y + 15}" font-size="12" fill="black">{control_name}</text>'
        )

        # Draw nested controls
        for child in parent_map.get(control_name, []):
            draw_control(child, x, y)  # Offset child controls by parent position

    # Draw top-level controls
    for control_name, control in controls.items():
        if "parent" not in control:  # Only draw root-level controls
            draw_control(control_name)

    svg_elements.append("</svg>")

    with open(output_file, "w", encoding="utf-8") as file:
        file.write("\n".join(svg_elements))

if __name__ == "__main__":
    controls, parent_map = extract_controls(r"C:\Users\Matthew Gracey\Documents\a2-coursework\a2-coursework\View\SignIn\SignInView.Designer.cs")
    generate_svg(controls, parent_map)
    print("SVG layout generated as 'form_layout.svg'.")

