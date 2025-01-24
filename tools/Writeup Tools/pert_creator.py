from pert_node import PertNode
import gantt_grabber 


def get_table(node: PertNode, id: str, x: int, y: int):
    return f"""
    <mxCell id="{id}-19" value="" style="shape=table;startSize=0;container=1;collapsible=0;childLayout=tableLayout;" parent="1" vertex="1">
      <mxGeometry x="{x}" y="{y}" width="180" height="120" as="geometry" />
    </mxCell>
    <mxCell id="{id}-20" value="" style="shape=tableRow;horizontal=0;startSize=0;swimlaneHead=0;swimlaneBody=0;strokeColor=inherit;top=0;left=0;bottom=0;right=0;collapsible=0;dropTarget=0;fillColor=none;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="{id}-19" vertex="1">
      <mxGeometry width="180" height="40" as="geometry" />
    </mxCell>
    <mxCell id="{id}-21" value="{node.task_name}" style="shape=partialRectangle;html=1;whiteSpace=wrap;connectable=0;strokeColor=inherit;overflow=hidden;fillColor=none;top=0;left=0;bottom=0;right=0;pointerEvents=1;rowspan=1;colspan=3;" parent="{id}-20" vertex="1">
      <mxGeometry width="180" height="40" as="geometry">
        <mxRectangle width="60" height="40" as="alternateBounds" />
      </mxGeometry>
    </mxCell>
    <mxCell id="{id}-22" value="" style="shape=partialRectangle;html=1;whiteSpace=wrap;connectable=0;strokeColor=inherit;overflow=hidden;fillColor=none;top=0;left=0;bottom=0;right=0;pointerEvents=1;" parent="{id}-20" vertex="1" visible="0">
      <mxGeometry x="60" width="60" height="40" as="geometry">
        <mxRectangle width="60" height="40" as="alternateBounds" />
      </mxGeometry>
    </mxCell>
    <mxCell id="{id}-23" value="" style="shape=partialRectangle;html=1;whiteSpace=wrap;connectable=0;strokeColor=inherit;overflow=hidden;fillColor=none;top=0;left=0;bottom=0;right=0;pointerEvents=1;" parent="{id}-20" vertex="1" visible="0">
      <mxGeometry x="120" width="60" height="40" as="geometry">
        <mxRectangle width="60" height="40" as="alternateBounds" />
      </mxGeometry>
    </mxCell>
    <mxCell id="{id}-24" value="" style="shape=tableRow;horizontal=0;startSize=0;swimlaneHead=0;swimlaneBody=0;strokeColor=inherit;top=0;left=0;bottom=0;right=0;collapsible=0;dropTarget=0;fillColor=none;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="{id}-19" vertex="1">
      <mxGeometry y="40" width="180" height="40" as="geometry" />
    </mxCell>
    <mxCell id="{id}-25" value="{node.duration}" style="shape=partialRectangle;html=1;whiteSpace=wrap;connectable=0;strokeColor=inherit;overflow=hidden;fillColor=none;top=0;left=0;bottom=0;right=0;pointerEvents=1;rowspan=2;colspan=1;" parent="{id}-24" vertex="1">
      <mxGeometry width="60" height="80" as="geometry">
        <mxRectangle width="60" height="40" as="alternateBounds" />
      </mxGeometry>
    </mxCell>
    <mxCell id="{id}-26" value="{node.es}" style="shape=partialRectangle;html=1;whiteSpace=wrap;connectable=0;strokeColor=inherit;overflow=hidden;fillColor=none;top=0;left=0;bottom=0;right=0;pointerEvents=1;" parent="{id}-24" vertex="1">
      <mxGeometry x="60" width="60" height="40" as="geometry">
        <mxRectangle width="60" height="40" as="alternateBounds" />
      </mxGeometry>
    </mxCell>
    <mxCell id="{id}-27" value="{node.ef}" style="shape=partialRectangle;html=1;whiteSpace=wrap;connectable=0;strokeColor=inherit;overflow=hidden;fillColor=none;top=0;left=0;bottom=0;right=0;pointerEvents=1;" parent="{id}-24" vertex="1">
      <mxGeometry x="120" width="60" height="40" as="geometry">
        <mxRectangle width="60" height="40" as="alternateBounds" />
      </mxGeometry>
    </mxCell>
    <mxCell id="{id}-28" value="" style="shape=tableRow;horizontal=0;startSize=0;swimlaneHead=0;swimlaneBody=0;strokeColor=inherit;top=0;left=0;bottom=0;right=0;collapsible=0;dropTarget=0;fillColor=none;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="{id}-19" vertex="1">
      <mxGeometry y="80" width="180" height="40" as="geometry" />
    </mxCell>
    <mxCell id="{id}-29" value="" style="shape=partialRectangle;html=1;whiteSpace=wrap;connectable=0;strokeColor=inherit;overflow=hidden;fillColor=none;top=0;left=0;bottom=0;right=0;pointerEvents=1;" parent="{id}-28" vertex="1" visible="0">
      <mxGeometry width="60" height="40" as="geometry">
        <mxRectangle width="60" height="40" as="alternateBounds" />
      </mxGeometry>
    </mxCell>
    <mxCell id="{id}-30" value="{node.ls}" style="shape=partialRectangle;html=1;whiteSpace=wrap;connectable=0;strokeColor=inherit;overflow=hidden;fillColor=none;top=0;left=0;bottom=0;right=0;pointerEvents=1;" parent="{id}-28" vertex="1">
      <mxGeometry x="60" width="60" height="40" as="geometry">
        <mxRectangle width="60" height="40" as="alternateBounds" />
      </mxGeometry>
    </mxCell>
    <mxCell id="{id}-31" value="{node.lf}" style="shape=partialRectangle;html=1;whiteSpace=wrap;connectable=0;strokeColor=inherit;overflow=hidden;fillColor=none;top=0;left=0;bottom=0;right=0;pointerEvents=1;" parent="{id}-28" vertex="1">
      <mxGeometry x="120" width="60" height="40" as="geometry">
        <mxRectangle width="60" height="40" as="alternateBounds" />
      </mxGeometry>
    </mxCell>
    """


def wrap_xml_outline(text):
    return f"""
<mxfile host="app.diagrams.net" agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36" version="26.0.7">
  <diagram name="Page-1" id="9c096ad6-e400-ecc8-3e38-643d2caac077">
    <mxGraphModel dx="1149" dy="674" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1.5" pageWidth="1169" pageHeight="826" background="none" math="0" shadow="0">
      <root>
        <mxCell id="0" style=";html=1;" />
        <mxCell id="1" style=";html=1;" parent="0" />
        {text}
      </root>
    </mxGraphModel>
  </diagram>
</mxfile>
    """

def main():
    nodes = gantt_grabber.grab(open('Gantt.gantt').read())

    table_xml = []
    for i in range(len(nodes)):
        table_xml.append(get_table(nodes[i], hash(i), i * 20, i * 20))

    text = wrap_xml_outline("".join(table_xml))

    file = open("test.drawio", "w")
    file.write(text)



main()
