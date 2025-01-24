# This code converts the gantt chart I created with online Gantt to a PERT chart
# I created the Gantt chart first, so this code converts it to a series of nodes
# from the json representation provided by Gantt Online


from pert_node import PertNode
import json


file_path = 'Gantt.gantt'


def main():
    file = open(file_path)
    text = file.read()
    grab(text)


def grab(text):
    pert_nodes = []

    json_value = json.loads(text)
    # Pretty print the json
    # print(json.dumps(json_value, indent=4))
    
    tasks = json_value["data"]
    for task in tasks: 
        if ("subtasks" in task):
            for subtask in task["subtasks"]:
                pert_nodes.append(create_node(subtask))
        else:
            pert_nodes.append(create_node(task))

    return pert_nodes


def create_node(json_task):
    return PertNode(json_task["TaskName"], json_task["Duration"], 0, 0, 0, 0)


if __name__ == '__main__':
    main()
